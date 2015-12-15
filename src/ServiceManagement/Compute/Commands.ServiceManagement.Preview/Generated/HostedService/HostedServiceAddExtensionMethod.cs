// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.WindowsAzure.Commands.Compute.Automation.Models;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateHostedServiceAddExtensionDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pServiceName = new RuntimeDefinedParameter();
            pServiceName.Name = "ServiceName";
            pServiceName.ParameterType = typeof(string);
            pServiceName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pServiceName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ServiceName", pServiceName);

            var pId = new RuntimeDefinedParameter();
            pId.Name = "Id";
            pId.ParameterType = typeof(string);
            pId.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = false
            });
            pId.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Id", pId);

            var pPrivateConfiguration = new RuntimeDefinedParameter();
            pPrivateConfiguration.Name = "PrivateConfiguration";
            pPrivateConfiguration.ParameterType = typeof(string);
            pPrivateConfiguration.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = false
            });
            pPrivateConfiguration.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("PrivateConfiguration", pPrivateConfiguration);

            var pProviderNamespace = new RuntimeDefinedParameter();
            pProviderNamespace.Name = "ProviderNamespace";
            pProviderNamespace.ParameterType = typeof(string);
            pProviderNamespace.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 4,
                Mandatory = false
            });
            pProviderNamespace.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ProviderNamespace", pProviderNamespace);

            var pPublicConfiguration = new RuntimeDefinedParameter();
            pPublicConfiguration.Name = "PublicConfiguration";
            pPublicConfiguration.ParameterType = typeof(string);
            pPublicConfiguration.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 5,
                Mandatory = false
            });
            pPublicConfiguration.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("PublicConfiguration", pPublicConfiguration);

            var pThumbprint = new RuntimeDefinedParameter();
            pThumbprint.Name = "Thumbprint";
            pThumbprint.ParameterType = typeof(string);
            pThumbprint.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 6,
                Mandatory = false
            });
            pThumbprint.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Thumbprint", pThumbprint);

            var pThumbprintAlgorithm = new RuntimeDefinedParameter();
            pThumbprintAlgorithm.Name = "ThumbprintAlgorithm";
            pThumbprintAlgorithm.ParameterType = typeof(string);
            pThumbprintAlgorithm.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 7,
                Mandatory = false
            });
            pThumbprintAlgorithm.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ThumbprintAlgorithm", pThumbprintAlgorithm);

            var pType = new RuntimeDefinedParameter();
            pType.Name = "Type";
            pType.ParameterType = typeof(string);
            pType.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 8,
                Mandatory = false
            });
            pType.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Type", pType);

            var pVersion = new RuntimeDefinedParameter();
            pVersion.Name = "Version";
            pVersion.ParameterType = typeof(string);
            pVersion.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 9,
                Mandatory = false
            });
            pVersion.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Version", pVersion);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 10,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteHostedServiceAddExtensionMethod(object[] invokeMethodInputParameters)
        {
            string serviceName = (string)ParseParameter(invokeMethodInputParameters[0]);
            var parameters = new HostedServiceAddExtensionParameters();
            var pId = (string) ParseParameter(invokeMethodInputParameters[1]);
            parameters.Id = string.IsNullOrEmpty(pId) ? null : pId;
            var pPrivateConfiguration = (string) ParseParameter(invokeMethodInputParameters[2]);
            parameters.PrivateConfiguration = string.IsNullOrEmpty(pPrivateConfiguration) ? null : pPrivateConfiguration;
            var pProviderNamespace = (string) ParseParameter(invokeMethodInputParameters[3]);
            parameters.ProviderNamespace = string.IsNullOrEmpty(pProviderNamespace) ? null : pProviderNamespace;
            var pPublicConfiguration = (string) ParseParameter(invokeMethodInputParameters[4]);
            parameters.PublicConfiguration = string.IsNullOrEmpty(pPublicConfiguration) ? null : pPublicConfiguration;
            var pThumbprint = (string) ParseParameter(invokeMethodInputParameters[5]);
            parameters.Thumbprint = string.IsNullOrEmpty(pThumbprint) ? null : pThumbprint;
            var pThumbprintAlgorithm = (string) ParseParameter(invokeMethodInputParameters[6]);
            parameters.ThumbprintAlgorithm = string.IsNullOrEmpty(pThumbprintAlgorithm) ? null : pThumbprintAlgorithm;
            var pType = (string) ParseParameter(invokeMethodInputParameters[7]);
            parameters.Type = string.IsNullOrEmpty(pType) ? null : pType;
            var pVersion = (string) ParseParameter(invokeMethodInputParameters[8]);
            parameters.Version = string.IsNullOrEmpty(pVersion) ? null : pVersion;

            var result = HostedServiceClient.AddExtension(serviceName, parameters);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateHostedServiceAddExtensionParameters()
        {
            string serviceName = string.Empty;
            var pId = string.Empty;
            var pPrivateConfiguration = string.Empty;
            var pProviderNamespace = string.Empty;
            var pPublicConfiguration = string.Empty;
            var pThumbprint = string.Empty;
            var pThumbprintAlgorithm = string.Empty;
            var pType = string.Empty;
            var pVersion = string.Empty;

            return ConvertFromObjectsToArguments(
                 new string[] { "ServiceName", "Id", "PrivateConfiguration", "ProviderNamespace", "PublicConfiguration", "Thumbprint", "ThumbprintAlgorithm", "Type", "Version" },
                 new object[] { serviceName, pId, pPrivateConfiguration, pProviderNamespace, pPublicConfiguration, pThumbprint, pThumbprintAlgorithm, pType, pVersion });
        }
    }
}
