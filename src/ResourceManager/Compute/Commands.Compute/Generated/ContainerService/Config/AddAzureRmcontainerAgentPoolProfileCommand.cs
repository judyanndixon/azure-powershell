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
    [Cmdlet("Add", "AzureRmcontainerAgentPoolProfile")]
    [OutputType(typeof(ContainerService))]
    public class AddAzureRmcontainerAgentPoolProfileCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public ContainerService ContainerService { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int? Count { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string VmSize { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string DnsPrefix { get; set; }

        protected override void ProcessRecord()
        {
            // AgentPoolProfiles
            if (this.ContainerService.AgentPoolProfiles == null)
            {
                this.ContainerService.AgentPoolProfiles = new List<Microsoft.Azure.Management.Compute.Models.ContainerServiceAgentPoolProfile>();
            }

            var vAgentPoolProfiles = new Microsoft.Azure.Management.Compute.Models.ContainerServiceAgentPoolProfile();

            vAgentPoolProfiles.Name = this.Name;
            vAgentPoolProfiles.Count = this.Count;
            vAgentPoolProfiles.VmSize = this.VmSize;
            vAgentPoolProfiles.DnsPrefix = this.DnsPrefix;
            this.ContainerService.AgentPoolProfiles.Add(vAgentPoolProfiles);
            WriteObject(this.ContainerService);
        }
    }
}

