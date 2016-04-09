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
    [Cmdlet(VerbsCommon.New, "AzureComputeArgumentList", DefaultParameterSetName = "CreateParameterListByMethodName")]
    [OutputType(typeof(object))]
    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        [Parameter(ParameterSetName = "CreateParameterListByMethodName", Mandatory = true, Position = 0)]
        [ValidateSet(
            "DeploymentAbortMigration",
            "DeploymentChangeConfigurationByName",
            "DeploymentChangeConfigurationBySlot",
            "DeploymentCommitMigration",
            "DeploymentCreate",
            "DeploymentDeleteByName",
            "DeploymentDeleteBySlot",
            "DeploymentDeleteRoleInstanceByDeploymentName",
            "DeploymentDeleteRoleInstanceByDeploymentSlot",
            "DeploymentGetByName",
            "DeploymentGetBySlot",
            "DeploymentGetPackageByName",
            "DeploymentGetPackageBySlot",
            "DeploymentListEvents",
            "DeploymentListEventsBySlot",
            "DeploymentPrepareMigration",
            "DeploymentRebootRoleInstanceByDeploymentName",
            "DeploymentRebootRoleInstanceByDeploymentSlot",
            "DeploymentRebuildRoleInstanceByDeploymentName",
            "DeploymentRebuildRoleInstanceByDeploymentSlot",
            "DeploymentReimageRoleInstanceByDeploymentName",
            "DeploymentReimageRoleInstanceByDeploymentSlot",
            "DeploymentRollbackUpdateOrUpgradeByDeploymentName",
            "DeploymentRollbackUpdateOrUpgradeByDeploymentSlot",
            "DeploymentSwap",
            "DeploymentUpdateStatusByDeploymentName",
            "DeploymentUpdateStatusByDeploymentSlot",
            "DeploymentUpgradeByName",
            "DeploymentUpgradeBySlot",
            "DeploymentWalkUpgradeDomainByDeploymentName",
            "DeploymentWalkUpgradeDomainByDeploymentSlot",
            "DNSServerAddDNSServer",
            "DNSServerDeleteDNSServer",
            "DNSServerUpdateDNSServer",
            "ExtensionImageRegister",
            "ExtensionImageUnregister",
            "ExtensionImageUpdate",
            "HostedServiceAddExtension",
            "HostedServiceCheckNameAvailability",
            "HostedServiceCreate",
            "HostedServiceDelete",
            "HostedServiceDeleteAll",
            "HostedServiceDeleteExtension",
            "HostedServiceGet",
            "HostedServiceGetDetailed",
            "HostedServiceGetExtension",
            "HostedServiceList",
            "HostedServiceListAvailableExtensions",
            "HostedServiceListExtensions",
            "HostedServiceListExtensionVersions",
            "HostedServiceListPublisherExtensions",
            "HostedServiceUpdate",
            "LoadBalancerCreate",
            "LoadBalancerDelete",
            "LoadBalancerUpdate",
            "OperatingSystemList",
            "OperatingSystemListFamilies",
            "ServiceCertificateCreate",
            "ServiceCertificateDelete",
            "ServiceCertificateGet",
            "ServiceCertificateList",
            "VirtualMachineDiskCreateDataDisk",
            "VirtualMachineDiskCreateDisk",
            "VirtualMachineDiskDeleteDataDisk",
            "VirtualMachineDiskDeleteDisk",
            "VirtualMachineDiskGetDataDisk",
            "VirtualMachineDiskGetDisk",
            "VirtualMachineDiskListDisks",
            "VirtualMachineDiskUpdateDataDisk",
            "VirtualMachineDiskUpdateDisk",
            "VirtualMachineDiskUpdateDiskSize",
            "VirtualMachineExtensionList",
            "VirtualMachineExtensionListVersions",
            "VirtualMachineCaptureOSImage",
            "VirtualMachineCaptureVMImage",
            "VirtualMachineCreate",
            "VirtualMachineCreateDeployment",
            "VirtualMachineDelete",
            "VirtualMachineGet",
            "VirtualMachineGetRemoteDesktopFile",
            "VirtualMachineRestart",
            "VirtualMachineShutdown",
            "VirtualMachineShutdownRoles",
            "VirtualMachineStart",
            "VirtualMachineStartRoles",
            "VirtualMachineUpdate",
            "VirtualMachineUpdateLoadBalancedEndpointSet",
            "VirtualMachineOSImageCreate",
            "VirtualMachineOSImageDelete",
            "VirtualMachineOSImageGet",
            "VirtualMachineOSImageGetDetails",
            "VirtualMachineOSImageList",
            "VirtualMachineOSImageReplicate",
            "VirtualMachineOSImageShare",
            "VirtualMachineOSImageUnreplicate",
            "VirtualMachineOSImageUpdate",
            "VirtualMachineVMImageCreate",
            "VirtualMachineVMImageDelete",
            "VirtualMachineVMImageGetDetails",
            "VirtualMachineVMImageList",
            "VirtualMachineVMImageReplicate",
            "VirtualMachineVMImageShare",
            "VirtualMachineVMImageUnreplicate",
            "VirtualMachineVMImageUpdate"
        )]
        public virtual string MethodName { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ExecuteClientAction(() =>
            {
                if (ParameterSetName == "CreateParameterListByMethodName")
                {
                    switch (MethodName)
                    {
                        case "DeploymentAbortMigration" : WriteObject(CreateDeploymentAbortMigrationParameters(), true); break;
                        case "DeploymentChangeConfigurationByName" : WriteObject(CreateDeploymentChangeConfigurationByNameParameters(), true); break;
                        case "DeploymentChangeConfigurationBySlot" : WriteObject(CreateDeploymentChangeConfigurationBySlotParameters(), true); break;
                        case "DeploymentCommitMigration" : WriteObject(CreateDeploymentCommitMigrationParameters(), true); break;
                        case "DeploymentCreate" : WriteObject(CreateDeploymentCreateParameters(), true); break;
                        case "DeploymentDeleteByName" : WriteObject(CreateDeploymentDeleteByNameParameters(), true); break;
                        case "DeploymentDeleteBySlot" : WriteObject(CreateDeploymentDeleteBySlotParameters(), true); break;
                        case "DeploymentDeleteRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentDeleteRoleInstanceByDeploymentNameParameters(), true); break;
                        case "DeploymentDeleteRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentDeleteRoleInstanceByDeploymentSlotParameters(), true); break;
                        case "DeploymentGetByName" : WriteObject(CreateDeploymentGetByNameParameters(), true); break;
                        case "DeploymentGetBySlot" : WriteObject(CreateDeploymentGetBySlotParameters(), true); break;
                        case "DeploymentGetPackageByName" : WriteObject(CreateDeploymentGetPackageByNameParameters(), true); break;
                        case "DeploymentGetPackageBySlot" : WriteObject(CreateDeploymentGetPackageBySlotParameters(), true); break;
                        case "DeploymentListEvents" : WriteObject(CreateDeploymentListEventsParameters(), true); break;
                        case "DeploymentListEventsBySlot" : WriteObject(CreateDeploymentListEventsBySlotParameters(), true); break;
                        case "DeploymentPrepareMigration" : WriteObject(CreateDeploymentPrepareMigrationParameters(), true); break;
                        case "DeploymentRebootRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentRebootRoleInstanceByDeploymentNameParameters(), true); break;
                        case "DeploymentRebootRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentRebootRoleInstanceByDeploymentSlotParameters(), true); break;
                        case "DeploymentRebuildRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentRebuildRoleInstanceByDeploymentNameParameters(), true); break;
                        case "DeploymentRebuildRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentRebuildRoleInstanceByDeploymentSlotParameters(), true); break;
                        case "DeploymentReimageRoleInstanceByDeploymentName" : WriteObject(CreateDeploymentReimageRoleInstanceByDeploymentNameParameters(), true); break;
                        case "DeploymentReimageRoleInstanceByDeploymentSlot" : WriteObject(CreateDeploymentReimageRoleInstanceByDeploymentSlotParameters(), true); break;
                        case "DeploymentRollbackUpdateOrUpgradeByDeploymentName" : WriteObject(CreateDeploymentRollbackUpdateOrUpgradeByDeploymentNameParameters(), true); break;
                        case "DeploymentRollbackUpdateOrUpgradeByDeploymentSlot" : WriteObject(CreateDeploymentRollbackUpdateOrUpgradeByDeploymentSlotParameters(), true); break;
                        case "DeploymentSwap" : WriteObject(CreateDeploymentSwapParameters(), true); break;
                        case "DeploymentUpdateStatusByDeploymentName" : WriteObject(CreateDeploymentUpdateStatusByDeploymentNameParameters(), true); break;
                        case "DeploymentUpdateStatusByDeploymentSlot" : WriteObject(CreateDeploymentUpdateStatusByDeploymentSlotParameters(), true); break;
                        case "DeploymentUpgradeByName" : WriteObject(CreateDeploymentUpgradeByNameParameters(), true); break;
                        case "DeploymentUpgradeBySlot" : WriteObject(CreateDeploymentUpgradeBySlotParameters(), true); break;
                        case "DeploymentWalkUpgradeDomainByDeploymentName" : WriteObject(CreateDeploymentWalkUpgradeDomainByDeploymentNameParameters(), true); break;
                        case "DeploymentWalkUpgradeDomainByDeploymentSlot" : WriteObject(CreateDeploymentWalkUpgradeDomainByDeploymentSlotParameters(), true); break;
                        case "DNSServerAddDNSServer" : WriteObject(CreateDNSServerAddDNSServerParameters(), true); break;
                        case "DNSServerDeleteDNSServer" : WriteObject(CreateDNSServerDeleteDNSServerParameters(), true); break;
                        case "DNSServerUpdateDNSServer" : WriteObject(CreateDNSServerUpdateDNSServerParameters(), true); break;
                        case "ExtensionImageRegister" : WriteObject(CreateExtensionImageRegisterParameters(), true); break;
                        case "ExtensionImageUnregister" : WriteObject(CreateExtensionImageUnregisterParameters(), true); break;
                        case "ExtensionImageUpdate" : WriteObject(CreateExtensionImageUpdateParameters(), true); break;
                        case "HostedServiceAddExtension" : WriteObject(CreateHostedServiceAddExtensionParameters(), true); break;
                        case "HostedServiceCheckNameAvailability" : WriteObject(CreateHostedServiceCheckNameAvailabilityParameters(), true); break;
                        case "HostedServiceCreate" : WriteObject(CreateHostedServiceCreateParameters(), true); break;
                        case "HostedServiceDelete" : WriteObject(CreateHostedServiceDeleteParameters(), true); break;
                        case "HostedServiceDeleteAll" : WriteObject(CreateHostedServiceDeleteAllParameters(), true); break;
                        case "HostedServiceDeleteExtension" : WriteObject(CreateHostedServiceDeleteExtensionParameters(), true); break;
                        case "HostedServiceGet" : WriteObject(CreateHostedServiceGetParameters(), true); break;
                        case "HostedServiceGetDetailed" : WriteObject(CreateHostedServiceGetDetailedParameters(), true); break;
                        case "HostedServiceGetExtension" : WriteObject(CreateHostedServiceGetExtensionParameters(), true); break;
                        case "HostedServiceList" : WriteObject(CreateHostedServiceListParameters(), true); break;
                        case "HostedServiceListAvailableExtensions" : WriteObject(CreateHostedServiceListAvailableExtensionsParameters(), true); break;
                        case "HostedServiceListExtensions" : WriteObject(CreateHostedServiceListExtensionsParameters(), true); break;
                        case "HostedServiceListExtensionVersions" : WriteObject(CreateHostedServiceListExtensionVersionsParameters(), true); break;
                        case "HostedServiceListPublisherExtensions" : WriteObject(CreateHostedServiceListPublisherExtensionsParameters(), true); break;
                        case "HostedServiceUpdate" : WriteObject(CreateHostedServiceUpdateParameters(), true); break;
                        case "LoadBalancerCreate" : WriteObject(CreateLoadBalancerCreateParameters(), true); break;
                        case "LoadBalancerDelete" : WriteObject(CreateLoadBalancerDeleteParameters(), true); break;
                        case "LoadBalancerUpdate" : WriteObject(CreateLoadBalancerUpdateParameters(), true); break;
                        case "OperatingSystemList" : WriteObject(CreateOperatingSystemListParameters(), true); break;
                        case "OperatingSystemListFamilies" : WriteObject(CreateOperatingSystemListFamiliesParameters(), true); break;
                        case "ServiceCertificateCreate" : WriteObject(CreateServiceCertificateCreateParameters(), true); break;
                        case "ServiceCertificateDelete" : WriteObject(CreateServiceCertificateDeleteParameters(), true); break;
                        case "ServiceCertificateGet" : WriteObject(CreateServiceCertificateGetParameters(), true); break;
                        case "ServiceCertificateList" : WriteObject(CreateServiceCertificateListParameters(), true); break;
                        case "VirtualMachineDiskCreateDataDisk" : WriteObject(CreateVirtualMachineDiskCreateDataDiskParameters(), true); break;
                        case "VirtualMachineDiskCreateDisk" : WriteObject(CreateVirtualMachineDiskCreateDiskParameters(), true); break;
                        case "VirtualMachineDiskDeleteDataDisk" : WriteObject(CreateVirtualMachineDiskDeleteDataDiskParameters(), true); break;
                        case "VirtualMachineDiskDeleteDisk" : WriteObject(CreateVirtualMachineDiskDeleteDiskParameters(), true); break;
                        case "VirtualMachineDiskGetDataDisk" : WriteObject(CreateVirtualMachineDiskGetDataDiskParameters(), true); break;
                        case "VirtualMachineDiskGetDisk" : WriteObject(CreateVirtualMachineDiskGetDiskParameters(), true); break;
                        case "VirtualMachineDiskListDisks" : WriteObject(CreateVirtualMachineDiskListDisksParameters(), true); break;
                        case "VirtualMachineDiskUpdateDataDisk" : WriteObject(CreateVirtualMachineDiskUpdateDataDiskParameters(), true); break;
                        case "VirtualMachineDiskUpdateDisk" : WriteObject(CreateVirtualMachineDiskUpdateDiskParameters(), true); break;
                        case "VirtualMachineDiskUpdateDiskSize" : WriteObject(CreateVirtualMachineDiskUpdateDiskSizeParameters(), true); break;
                        case "VirtualMachineExtensionList" : WriteObject(CreateVirtualMachineExtensionListParameters(), true); break;
                        case "VirtualMachineExtensionListVersions" : WriteObject(CreateVirtualMachineExtensionListVersionsParameters(), true); break;
                        case "VirtualMachineCaptureOSImage" : WriteObject(CreateVirtualMachineCaptureOSImageParameters(), true); break;
                        case "VirtualMachineCaptureVMImage" : WriteObject(CreateVirtualMachineCaptureVMImageParameters(), true); break;
                        case "VirtualMachineCreate" : WriteObject(CreateVirtualMachineCreateParameters(), true); break;
                        case "VirtualMachineCreateDeployment" : WriteObject(CreateVirtualMachineCreateDeploymentParameters(), true); break;
                        case "VirtualMachineDelete" : WriteObject(CreateVirtualMachineDeleteParameters(), true); break;
                        case "VirtualMachineGet" : WriteObject(CreateVirtualMachineGetParameters(), true); break;
                        case "VirtualMachineGetRemoteDesktopFile" : WriteObject(CreateVirtualMachineGetRemoteDesktopFileParameters(), true); break;
                        case "VirtualMachineRestart" : WriteObject(CreateVirtualMachineRestartParameters(), true); break;
                        case "VirtualMachineShutdown" : WriteObject(CreateVirtualMachineShutdownParameters(), true); break;
                        case "VirtualMachineShutdownRoles" : WriteObject(CreateVirtualMachineShutdownRolesParameters(), true); break;
                        case "VirtualMachineStart" : WriteObject(CreateVirtualMachineStartParameters(), true); break;
                        case "VirtualMachineStartRoles" : WriteObject(CreateVirtualMachineStartRolesParameters(), true); break;
                        case "VirtualMachineUpdate" : WriteObject(CreateVirtualMachineUpdateParameters(), true); break;
                        case "VirtualMachineUpdateLoadBalancedEndpointSet" : WriteObject(CreateVirtualMachineUpdateLoadBalancedEndpointSetParameters(), true); break;
                        case "VirtualMachineOSImageCreate" : WriteObject(CreateVirtualMachineOSImageCreateParameters(), true); break;
                        case "VirtualMachineOSImageDelete" : WriteObject(CreateVirtualMachineOSImageDeleteParameters(), true); break;
                        case "VirtualMachineOSImageGet" : WriteObject(CreateVirtualMachineOSImageGetParameters(), true); break;
                        case "VirtualMachineOSImageGetDetails" : WriteObject(CreateVirtualMachineOSImageGetDetailsParameters(), true); break;
                        case "VirtualMachineOSImageList" : WriteObject(CreateVirtualMachineOSImageListParameters(), true); break;
                        case "VirtualMachineOSImageReplicate" : WriteObject(CreateVirtualMachineOSImageReplicateParameters(), true); break;
                        case "VirtualMachineOSImageShare" : WriteObject(CreateVirtualMachineOSImageShareParameters(), true); break;
                        case "VirtualMachineOSImageUnreplicate" : WriteObject(CreateVirtualMachineOSImageUnreplicateParameters(), true); break;
                        case "VirtualMachineOSImageUpdate" : WriteObject(CreateVirtualMachineOSImageUpdateParameters(), true); break;
                        case "VirtualMachineVMImageCreate" : WriteObject(CreateVirtualMachineVMImageCreateParameters(), true); break;
                        case "VirtualMachineVMImageDelete" : WriteObject(CreateVirtualMachineVMImageDeleteParameters(), true); break;
                        case "VirtualMachineVMImageGetDetails" : WriteObject(CreateVirtualMachineVMImageGetDetailsParameters(), true); break;
                        case "VirtualMachineVMImageList" : WriteObject(CreateVirtualMachineVMImageListParameters(), true); break;
                        case "VirtualMachineVMImageReplicate" : WriteObject(CreateVirtualMachineVMImageReplicateParameters(), true); break;
                        case "VirtualMachineVMImageShare" : WriteObject(CreateVirtualMachineVMImageShareParameters(), true); break;
                        case "VirtualMachineVMImageUnreplicate" : WriteObject(CreateVirtualMachineVMImageUnreplicateParameters(), true); break;
                        case "VirtualMachineVMImageUpdate" : WriteObject(CreateVirtualMachineVMImageUpdateParameters(), true); break;
                        default : WriteWarning("Cannot find the method by name = '" + MethodName + "'."); break;
                    }
                }
            });
        }

    }
}
