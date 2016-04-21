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
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateContainerServiceDeleteDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pContainerServiceName = new RuntimeDefinedParameter();
            pContainerServiceName.Name = "ContainerServiceName";
            pContainerServiceName.ParameterType = typeof(string);
            pContainerServiceName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pContainerServiceName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ContainerServiceName", pContainerServiceName);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 3,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteContainerServiceDeleteMethod(object[] invokeMethodInputParameters)
        {
            string resourceGroupName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string containerServiceName = (string)ParseParameter(invokeMethodInputParameters[1]);

            ContainerServiceClient.Delete(resourceGroupName, containerServiceName);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateContainerServiceDeleteParameters()
        {
            string resourceGroupName = string.Empty;
            string containerServiceName = string.Empty;

            return ConvertFromObjectsToArguments(
                 new string[] { "ResourceGroupName", "ContainerServiceName" },
                 new object[] { resourceGroupName, containerServiceName });
        }
    }

    [Cmdlet("Remove", "AzureRmcontainer", DefaultParameterSetName = "InvokeByDynamicParameters")]
    public partial class RemoveAzureRmcontainer : InvokeAzureComputeMethodCmdlet
    {
        public RemoveAzureRmcontainer()
        {
        }

        public override string MethodName { get; set; }

        protected override void ProcessRecord()
        {
            this.MethodName = "ContainerServiceDelete";
            base.ProcessRecord();
        }

        public override object GetDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true,
                ValueFromPipeline = false
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pContainerServiceName = new RuntimeDefinedParameter();
            pContainerServiceName.Name = "ContainerServiceName";
            pContainerServiceName.ParameterType = typeof(string);
            pContainerServiceName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true,
                ValueFromPipeline = false
            });
            pContainerServiceName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ContainerServiceName", pContainerServiceName);

            return dynamicParameters;
        }
    }
}
