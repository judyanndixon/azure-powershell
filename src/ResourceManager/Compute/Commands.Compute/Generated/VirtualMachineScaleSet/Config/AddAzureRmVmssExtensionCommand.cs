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

using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("Add", "AzureRmVmssExtension")]
    [OutputType(typeof(VirtualMachineScaleSet))]
    public class AddAzureRmVmssExtensionCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string Publisher { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string VirtualMachineScaleSetExtensionType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string TypeHandlerVersion { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public bool? AutoUpgradeMinorVersion { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public Object Setting { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public Object ProtectedSetting { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public string Id { get; set; }

        protected override void ProcessRecord()
        {
            // VirtualMachineProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
            }

            // ExtensionProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtensionProfile();
            }

            // Extensions
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions = new List<Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtension>();
            }

            var vExtensions = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtension();

            vExtensions.Name = this.Name;
            vExtensions.Publisher = this.Publisher;
            vExtensions.VirtualMachineScaleSetExtensionType = this.VirtualMachineScaleSetExtensionType;
            vExtensions.TypeHandlerVersion = this.TypeHandlerVersion;
            vExtensions.AutoUpgradeMinorVersion = this.AutoUpgradeMinorVersion;
            vExtensions.Settings = this.Setting;
            vExtensions.ProtectedSettings = this.ProtectedSetting;
            vExtensions.Id = this.Id;
            this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions.Add(vExtensions);
            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}

