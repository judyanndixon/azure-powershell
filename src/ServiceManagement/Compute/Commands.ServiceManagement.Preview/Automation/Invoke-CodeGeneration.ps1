﻿# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

# This script is to generate a set of operation and parameter cmdlets that
# are mapped from the source client library. 
#
# For example, 'ComputeManagementClient.VirtualMachines.Start()' would be
# 'Invoke-AzureVirtualMachineStartMethod'.
#
# It's also possible to map the actual verb from function to cmdlet, e.g.
# the above example would be 'Start-AzureVirtualMachine', but to keep it
# simple and consistent, we would like to use the generic verb.

[CmdletBinding()]
param(
    # The folder that contains the source DLL, and all its dependency DLLs.
    [Parameter(Mandatory = $true)]
    [string]$dllFolder,

    # The target output folder, and the generated files would be organized in
    # the sub-folder called 'Generated'.
    [Parameter(Mandatory = $true)]
    [string]$outFolder,
    
    # The namespace of the Compute client library
    [Parameter(Mandatory = $true)]
    [string]$clientNameSpace = 'Microsoft.WindowsAzure.Management.Compute',

    # The base cmdlet from which all automation cmdlets derive
    [Parameter(Mandatory = $false)]
    [string]$baseCmdletFullName = 'Microsoft.WindowsAzure.Commands.Utilities.Common.ServiceManagementBaseCmdlet',

    # The property field to access the client wrapper class from the base cmdlet
    [Parameter(Mandatory = $false)]
    [string]$baseClientFullName = 'ComputeClient',
    
    # Cmdlet Code Generation Flavor
    # 1. Invoke (default) that uses Invoke as the verb, and Operation + Method (e.g. VirtualMachine + Get)
    # 2. Verb style that maps the method name to a certain common PS verb (e.g. CreateOrUpdate -> New)
    [Parameter(Mandatory = $false)]
    [string]$cmdletFlavor = 'Invoke',

    # CLI Command Code Generation Flavor
    [Parameter(Mandatory = $false)]
    [string[]]$cliCommandFlavor = 'Verb',

    # The filter of operation name for code generation
    # e.g. "VirtualMachineScaleSet","VirtualMachineScaleSetVM"
    [Parameter(Mandatory = $false)]
    [string[]]$operationNameFilter = $null
)

. "$PSScriptRoot\Import-CommonVariables.ps1";
. "$PSScriptRoot\Import-AssemblyFunction.ps1";
. "$PSScriptRoot\Import-StringFunction.ps1";
. "$PSScriptRoot\Import-TypeFunction.ps1";
. "$PSScriptRoot\Import-OperationFunction.ps1";
. "$PSScriptRoot\Import-WriterFunction.ps1";

# Code Generation Main Run
$outFolder += '/Generated';

$output = Get-ChildItem -Path $dllFolder | Out-String;

# Set-FileContent -Path ($outFolder + '/Output.txt');
# Write-Verbose "List items under the folder: $dllFolder"
# Write-Verbose $output;

$dllfile = $clientNameSpace + '.dll';
$dllFileFullPath = $dllFolder + '\' + $dllfile;

if (-not (Test-Path -Path $dllFileFullPath))
{
    Write-Verbose "DLL file `'$dllFileFullPath`' not found. Exit.";
}
else
{
    $assembly = Load-AssemblyFile $dllFileFullPath;
    
    # All original types
    $types = $assembly.GetTypes();
    $clientNameSpace = Get-AzureNameSpace $dllFileFullPath;
    $filtered_types = Get-FilteredOperationTypes $types $clientNameSpace $operationNameFilter;

    # Write Base Cmdlet File
    $opNameList = ($filtered_types | select -ExpandProperty Name);
    if ($opNameList -eq $null)
    {
        Write-Verbose "No qualifed operations found. Exit.";
        return -1;
    }

    $auto_base_cmdlet_name = $component_name + 'AutomationBaseCmdlet';
    $baseCmdletFileFullName = $outFolder + '\' + "$auto_base_cmdlet_name.cs";
    $clientClassType = $types | where { $_.Namespace -eq $clientNameSpace -and $_.Name -eq ('I' + $component_name + 'ManagementClient') };
    Write-BaseCmdletFile $baseCmdletFileFullName $opNameList $clientClassType;

    # PSArgument File
    $model_class_out_folder = $outFolder + '\Models';
    if (Test-Path -Path $model_class_out_folder)
    {
        $st = rmdir -Recurse -Force $model_class_out_folder;
    }
    $st = mkdir -Force $model_class_out_folder;
    $psargument_model_class_file_path = $model_class_out_folder + '\PSArgument.cs';
    Write-PSArgumentFile $psargument_model_class_file_path;

    $invoke_cmdlet_class_name = 'InvokeAzure' + $component_name + 'MethodCmdlet';
    $invoke_cmdlet_file_name = $outFolder + '\' + "$invoke_cmdlet_class_name.cs";
    $parameter_cmdlet_class_name = 'NewAzure' + $component_name + 'ArgumentListCmdlet';
    $parameter_cmdlet_file_name = $outFolder + '\' + "$parameter_cmdlet_class_name.cs";
    $new_object_cmdlet_class_name = 'NewAzure' + $component_name + 'ParameterObjectCmdlet';
    $new_object_cmdlet_file_name = $outFolder + '\' + "$new_object_cmdlet_class_name.cs";

    [System.Reflection.ParameterInfo[]]$parameter_type_info_list = @();
    $dynamic_param_method_code = @();
    $invoke_cmdlet_method_code = @();
    $parameter_cmdlet_method_code = @();
    $all_return_type_names = @();
    $formatXml = "";
    $cliCommandCodeMainBody = "";

    # Write Operation Cmdlet Files
    $operation_type_count = 0;
    $total_operation_type_count = $filtered_types.Count;
    foreach ($operation_type in $filtered_types)
    {
        $operation_type_count++;
        $operation_type_count_roman_index = Get-RomanNumeral $operation_type_count;
        $operation_nomalized_name = Get-OperationShortName $operation_type.Name;
        Write-Verbose '';
        Write-Verbose $BAR_LINE;
        Write-Verbose ("Chapter ${operation_type_count_roman_index}. " + $operation_nomalized_name + " (${operation_type_count}/${total_operation_type_count}) ");
        Write-Verbose $BAR_LINE;
    
        $opShortName = Get-OperationShortName $operation_type.Name;
        if ($opShortName.EndsWith("ScaleSets"))
        {
            $opFolderName = $opShortName.Replace('ScaleSets', 'ScaleSet');
            $opOutFolder = $outFolder + '/' + $opFolderName;
        }
        elseif ($opShortName.EndsWith("ScaleSetVMs"))
        {
            $opFolderName = $opShortName.Replace('ScaleSetVMs', 'ScaleSetVM');
            $opOutFolder = $outFolder + '/' + $opFolderName;
        }
        else
        {
            $opOutFolder = $outFolder + '/' + $opShortName;
        }
        
        if (Test-Path -Path $opOutFolder)
        {
            $st = rmdir -Recurse -Force $opOutFolder;
        }
        $st = mkdir -Force $opOutFolder;

        $methods = Get-OperationMethods $operation_type;
        if ($methods -eq $null -or $methods.Count -eq 0)
        {
            Write-Verbose "No methods found. Skip.";
            continue;
        }

        $qualified_methods = @();
        $total_method_count = 0;
        [System.Collections.Hashtable]$friendMethodDict = @{};
        [System.Collections.Hashtable]$pageMethodDict = @{};
        foreach ($mtItem in $methods)
        {
            [System.Reflection.MethodInfo]$methodInfo = $mtItem;
            if ($methodInfo.Name -like 'Begin*')
            {
                continue;
            }
            elseif ($methodInfo.Name -like '*Async')
            {
                continue;
            }
            else
            {
                Write-Verbose $methodInfo.Name;
            }

            $qualified_methods += $mtItem;
            $total_method_count++;

            # Handle Friend Methods
            if (-not $friendMethodDict.ContainsKey($mtItem.Name))
            {
                $searchName = $null;
                $matchedMethodInfo = $null;
                if ($mtItem.Name -eq 'Deallocate')
                {
                    $searchName = 'PowerOff';
                    $matchedMethodInfo = $methodInfo;
                }
                elseif ($mtItem.Name -eq 'Get')
                {
                    $searchName = 'GetInstanceView';
                    $matchedMethodInfo = $methodInfo;
                }
                elseif ($mtItem.Name -eq 'List')
                {
                    $searchName = 'ListAll';
                }
             
                if ($searchName -ne $null)
                {
                    $methods2 = Get-OperationMethods $operation_type;
                    $foundMethod = Find-MatchedMethod $searchName $methods2 $matchedMethodInfo;
                    if ($foundMethod -ne $null)
                    {
                        $friendMethodDict.Add($mtItem.Name, $foundMethod);
                    }
                }
            }
            
            # Handle Page Methods
            if ($mtItem.Name -like 'List*' -and (-not $pageMethodDict.ContainsKey($mtItem.Name)))
            {
                $methods2 = Get-OperationMethods $operation_type;
                $foundMethod = Find-MatchedMethod ($mtItem.Name + 'Next') $methods2;
                $pageMethodDict.Add($mtItem.Name, $foundMethod);
            }
        }
        
        $method_count = 0;
        foreach ($mtItem in $qualified_methods)
        {
            [System.Reflection.MethodInfo]$methodInfo = $mtItem;
            $method_count++;

            # Get Friend Method (if any)
            $friendMethodInfo = $null;
            if ($friendMethodDict.ContainsKey($methodInfo.Name))
            {
                $friendMethodInfo = $friendMethodDict[$methodInfo.Name];
            }
            
            $friendMethodMessage = '';
            if ($friendMethodInfo -ne $null -and $friendMethodInfo.Name -ne $null)
            {
                $friendMethodMessage = 'Friend=' + ($friendMethodInfo.Name.Replace('Async', '')) + '';
            }
            
            # Get Page Method (if any)
            $pageMethodInfo = $null;
            if ($pageMethodDict.ContainsKey($methodInfo.Name))
            {
                $pageMethodInfo = $pageMethodDict[$methodInfo.Name];
            }
            
            $pageMethodMessage = '';
            if ($pageMethodInfo -ne $null -and $pageMethodInfo.Name -ne $null)
            {
                $pageMethodMessage = 'Page=' + ($pageMethodInfo.Name.Replace('Async', '')) + '';
            }
            
            # Combine Get and List/ListAll Methods (if any)
            $combineGetAndList = $false;
            $combineGetAndListAll = $false;
            if ($mtItem.Name -eq 'Get')
            {
                $methods3 = Get-OperationMethods $operation_type;
                $foundMethod1 = Find-MatchedMethod 'List' $methods3;
                $foundMethod2 = Find-MatchedMethod 'ListAll' $methods3;
                
                if ($foundMethod1 -ne $null)
                {
                    $combineGetAndList = $true;
                }
                
                if ($foundMethod2 -ne $null)
                {
                    $combineGetAndListAll = $true;
                }
            }

            # Output Info for Method Signature
            Write-Verbose "";
            Write-Verbose $SEC_LINE;
            $methodMessage = "${operation_type_count_roman_index}. ${method_count}/${total_method_count} " + $methodInfo.Name.Replace('Async', '');
            if (($friendMethodMessage -ne '') -or ($pageMethodMessage -ne ''))
            {
                $methodMessage += ' {' + $friendMethodMessage;
                if ($friendMethodMessage -ne '' -and $pageMethodMessage -ne '')
                {
                    $methodMessage += ', ';
                }
                $methodMessage += $pageMethodMessage;
                $methodMessage += '}';
            }
            
            Write-Verbose $methodMessage;
            foreach ($paramInfoItem in $methodInfo.GetParameters())
            {
                [System.Reflection.ParameterInfo]$paramInfo = $paramInfoItem;
                if (($paramInfo.ParameterType.Name -like "I*Operations") -and ($paramInfo.Name -eq 'operations'))
                {
                    continue;
                }
                elseif ($paramInfo.ParameterType.FullName.EndsWith('CancellationToken'))
                {
                    continue;
                }

                Write-Verbose ("-" + $paramInfo.Name + " : " + $paramInfo.ParameterType);
            }
            Write-Verbose $SEC_LINE;

            $opCmdletFlavor = $cmdletFlavor;
            if ($SKIP_VERB_NOUN_CMDLET_LIST -contains $methodInfo.Name)
            {
                #Overwrite and skip these method's 'Verb' cmdlet flavor
                $opCmdletFlavor = 'None';
            }
            
            $outputs = (. $PSScriptRoot\Generate-FunctionCommand.ps1 -OperationName $opShortName `
                                                                     -MethodInfo $methodInfo `
                                                                     -ModelClassNameSpace $clientModelNameSpace `
                                                                     -FileOutputFolder $opOutFolder `
                                                                     -FunctionCmdletFlavor $opCmdletFlavor `
                                                                     -FriendMethodInfo $friendMethodInfo `
                                                                     -PageMethodInfo $pageMethodInfo `
                                                                     -CombineGetAndList $combineGetAndList `
                                                                     -CombineGetAndListAll $combineGetAndListAll );

            if ($outputs.Count -ne $null)
            {
                $dynamic_param_method_code += $outputs[-4];
                $invoke_cmdlet_method_code += $outputs[-3];
                $parameter_cmdlet_method_code += $outputs[-2];
                $cliCommandCodeMainBody += $outputs[-1];
            }

            if ($methodInfo.ReturnType.FullName -ne 'System.Void')
            {
                $returnTypeResult = Process-ReturnType -rt $methodInfo.ReturnType -allrt $all_return_type_names;
                $formatXml += $returnTypeResult[0];
                $all_return_type_names = $returnTypeResult[1];
            }
        }

        Write-InvokeCmdletFile $invoke_cmdlet_file_name $invoke_cmdlet_class_name $auto_base_cmdlet_name $clientClassType $filtered_types $invoke_cmdlet_method_code $dynamic_param_method_code;
        Write-InvokeParameterCmdletFile $parameter_cmdlet_file_name $parameter_cmdlet_class_name $auto_base_cmdlet_name $clientClassType $filtered_types $parameter_cmdlet_method_code;
        Write-NewParameterObjectCmdletFile $new_object_cmdlet_file_name $new_object_cmdlet_class_name $auto_base_cmdlet_name $clientClassType $filtered_types $parameter_cmdlet_method_code;
    }

    # XML 
    $xmlFilePath = $outFolder + '\' + $code_common_namespace + '.format.generated.ps1xml';
    Write-Verbose $BAR_LINE;
    Write-Verbose 'Writing XML Format File: ';
    Write-Verbose $xmlFilePath;
    Write-Verbose $BAR_LINE;
    Write-XmlFormatFile $xmlFilePath;

    # CLI
    if ($cliCommandFlavor -eq 'Verb')
    {
        Write-CLICommandFile $outFolder $cliCommandCodeMainBody;
    }

    Write-Verbose $BAR_LINE;
    Write-Verbose "Finished.";
    Write-Verbose $BAR_LINE;
}
