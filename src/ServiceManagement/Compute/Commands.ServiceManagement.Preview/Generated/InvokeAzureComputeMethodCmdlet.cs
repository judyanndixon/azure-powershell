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
    [Cmdlet(VerbsLifecycle.Invoke, "AzureComputeMethod", DefaultParameterSetName = "InvokeByDynamicParameters")]
    [OutputType(typeof(object))]
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet, IDynamicParameters
    {
        protected RuntimeDefinedParameterDictionary dynamicParameters;
        protected object[] argumentList;

        protected static object[] ConvertDynamicParameters(RuntimeDefinedParameterDictionary parameters)
        {
            List<object> paramList = new List<object>();

            foreach (var param in parameters)
            {
                paramList.Add(param.Value.Value);
            }

            return paramList.ToArray();
        }

        [Parameter(Mandatory = true, ParameterSetName = "InvokeByDynamicParameters", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "InvokeByStaticParameters", Position = 0)]
        [ValidateSet(
            "DeploymentChangeConfigurationByName",
            "DeploymentChangeConfigurationBySlot",
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

        protected object ParseParameter(object input)
        {
            if (input is PSObject)
            {
                return (input as PSObject).BaseObject;
            }
            else
            {
                return input;
            }
        }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ParameterSetName == "InvokeByDynamicParameters")
                {
                    argumentList = ConvertDynamicParameters(dynamicParameters);
                }
                else
                {
                    argumentList = ConvertFromArgumentsToObjects((object[])dynamicParameters["ArgumentList"].Value);
                }

                switch (MethodName)
                {
                    case "DeploymentChangeConfigurationByName" :
                        ExecuteDeploymentChangeConfigurationByNameMethod(argumentList);
                        break;
                    case "DeploymentChangeConfigurationBySlot" :
                        ExecuteDeploymentChangeConfigurationBySlotMethod(argumentList);
                        break;
                    case "DeploymentCreate" :
                        ExecuteDeploymentCreateMethod(argumentList);
                        break;
                    case "DeploymentDeleteByName" :
                        ExecuteDeploymentDeleteByNameMethod(argumentList);
                        break;
                    case "DeploymentDeleteBySlot" :
                        ExecuteDeploymentDeleteBySlotMethod(argumentList);
                        break;
                    case "DeploymentDeleteRoleInstanceByDeploymentName" :
                        ExecuteDeploymentDeleteRoleInstanceByDeploymentNameMethod(argumentList);
                        break;
                    case "DeploymentDeleteRoleInstanceByDeploymentSlot" :
                        ExecuteDeploymentDeleteRoleInstanceByDeploymentSlotMethod(argumentList);
                        break;
                    case "DeploymentGetByName" :
                        ExecuteDeploymentGetByNameMethod(argumentList);
                        break;
                    case "DeploymentGetBySlot" :
                        ExecuteDeploymentGetBySlotMethod(argumentList);
                        break;
                    case "DeploymentGetPackageByName" :
                        ExecuteDeploymentGetPackageByNameMethod(argumentList);
                        break;
                    case "DeploymentGetPackageBySlot" :
                        ExecuteDeploymentGetPackageBySlotMethod(argumentList);
                        break;
                    case "DeploymentListEvents" :
                        ExecuteDeploymentListEventsMethod(argumentList);
                        break;
                    case "DeploymentListEventsBySlot" :
                        ExecuteDeploymentListEventsBySlotMethod(argumentList);
                        break;
                    case "DeploymentRebootRoleInstanceByDeploymentName" :
                        ExecuteDeploymentRebootRoleInstanceByDeploymentNameMethod(argumentList);
                        break;
                    case "DeploymentRebootRoleInstanceByDeploymentSlot" :
                        ExecuteDeploymentRebootRoleInstanceByDeploymentSlotMethod(argumentList);
                        break;
                    case "DeploymentRebuildRoleInstanceByDeploymentName" :
                        ExecuteDeploymentRebuildRoleInstanceByDeploymentNameMethod(argumentList);
                        break;
                    case "DeploymentRebuildRoleInstanceByDeploymentSlot" :
                        ExecuteDeploymentRebuildRoleInstanceByDeploymentSlotMethod(argumentList);
                        break;
                    case "DeploymentReimageRoleInstanceByDeploymentName" :
                        ExecuteDeploymentReimageRoleInstanceByDeploymentNameMethod(argumentList);
                        break;
                    case "DeploymentReimageRoleInstanceByDeploymentSlot" :
                        ExecuteDeploymentReimageRoleInstanceByDeploymentSlotMethod(argumentList);
                        break;
                    case "DeploymentRollbackUpdateOrUpgradeByDeploymentName" :
                        ExecuteDeploymentRollbackUpdateOrUpgradeByDeploymentNameMethod(argumentList);
                        break;
                    case "DeploymentRollbackUpdateOrUpgradeByDeploymentSlot" :
                        ExecuteDeploymentRollbackUpdateOrUpgradeByDeploymentSlotMethod(argumentList);
                        break;
                    case "DeploymentSwap" :
                        ExecuteDeploymentSwapMethod(argumentList);
                        break;
                    case "DeploymentUpdateStatusByDeploymentName" :
                        ExecuteDeploymentUpdateStatusByDeploymentNameMethod(argumentList);
                        break;
                    case "DeploymentUpdateStatusByDeploymentSlot" :
                        ExecuteDeploymentUpdateStatusByDeploymentSlotMethod(argumentList);
                        break;
                    case "DeploymentUpgradeByName" :
                        ExecuteDeploymentUpgradeByNameMethod(argumentList);
                        break;
                    case "DeploymentUpgradeBySlot" :
                        ExecuteDeploymentUpgradeBySlotMethod(argumentList);
                        break;
                    case "DeploymentWalkUpgradeDomainByDeploymentName" :
                        ExecuteDeploymentWalkUpgradeDomainByDeploymentNameMethod(argumentList);
                        break;
                    case "DeploymentWalkUpgradeDomainByDeploymentSlot" :
                        ExecuteDeploymentWalkUpgradeDomainByDeploymentSlotMethod(argumentList);
                        break;
                    case "DNSServerAddDNSServer" :
                        ExecuteDNSServerAddDNSServerMethod(argumentList);
                        break;
                    case "DNSServerDeleteDNSServer" :
                        ExecuteDNSServerDeleteDNSServerMethod(argumentList);
                        break;
                    case "DNSServerUpdateDNSServer" :
                        ExecuteDNSServerUpdateDNSServerMethod(argumentList);
                        break;
                    case "ExtensionImageRegister" :
                        ExecuteExtensionImageRegisterMethod(argumentList);
                        break;
                    case "ExtensionImageUnregister" :
                        ExecuteExtensionImageUnregisterMethod(argumentList);
                        break;
                    case "ExtensionImageUpdate" :
                        ExecuteExtensionImageUpdateMethod(argumentList);
                        break;
                    case "HostedServiceAddExtension" :
                        ExecuteHostedServiceAddExtensionMethod(argumentList);
                        break;
                    case "HostedServiceCheckNameAvailability" :
                        ExecuteHostedServiceCheckNameAvailabilityMethod(argumentList);
                        break;
                    case "HostedServiceCreate" :
                        ExecuteHostedServiceCreateMethod(argumentList);
                        break;
                    case "HostedServiceDelete" :
                        ExecuteHostedServiceDeleteMethod(argumentList);
                        break;
                    case "HostedServiceDeleteAll" :
                        ExecuteHostedServiceDeleteAllMethod(argumentList);
                        break;
                    case "HostedServiceDeleteExtension" :
                        ExecuteHostedServiceDeleteExtensionMethod(argumentList);
                        break;
                    case "HostedServiceGet" :
                        ExecuteHostedServiceGetMethod(argumentList);
                        break;
                    case "HostedServiceGetDetailed" :
                        ExecuteHostedServiceGetDetailedMethod(argumentList);
                        break;
                    case "HostedServiceGetExtension" :
                        ExecuteHostedServiceGetExtensionMethod(argumentList);
                        break;
                    case "HostedServiceList" :
                        ExecuteHostedServiceListMethod(argumentList);
                        break;
                    case "HostedServiceListAvailableExtensions" :
                        ExecuteHostedServiceListAvailableExtensionsMethod(argumentList);
                        break;
                    case "HostedServiceListExtensions" :
                        ExecuteHostedServiceListExtensionsMethod(argumentList);
                        break;
                    case "HostedServiceListExtensionVersions" :
                        ExecuteHostedServiceListExtensionVersionsMethod(argumentList);
                        break;
                    case "HostedServiceUpdate" :
                        ExecuteHostedServiceUpdateMethod(argumentList);
                        break;
                    case "LoadBalancerCreate" :
                        ExecuteLoadBalancerCreateMethod(argumentList);
                        break;
                    case "LoadBalancerDelete" :
                        ExecuteLoadBalancerDeleteMethod(argumentList);
                        break;
                    case "LoadBalancerUpdate" :
                        ExecuteLoadBalancerUpdateMethod(argumentList);
                        break;
                    case "OperatingSystemList" :
                        ExecuteOperatingSystemListMethod(argumentList);
                        break;
                    case "OperatingSystemListFamilies" :
                        ExecuteOperatingSystemListFamiliesMethod(argumentList);
                        break;
                    case "ServiceCertificateCreate" :
                        ExecuteServiceCertificateCreateMethod(argumentList);
                        break;
                    case "ServiceCertificateDelete" :
                        ExecuteServiceCertificateDeleteMethod(argumentList);
                        break;
                    case "ServiceCertificateGet" :
                        ExecuteServiceCertificateGetMethod(argumentList);
                        break;
                    case "ServiceCertificateList" :
                        ExecuteServiceCertificateListMethod(argumentList);
                        break;
                    case "VirtualMachineDiskCreateDataDisk" :
                        ExecuteVirtualMachineDiskCreateDataDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskCreateDisk" :
                        ExecuteVirtualMachineDiskCreateDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskDeleteDataDisk" :
                        ExecuteVirtualMachineDiskDeleteDataDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskDeleteDisk" :
                        ExecuteVirtualMachineDiskDeleteDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskGetDataDisk" :
                        ExecuteVirtualMachineDiskGetDataDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskGetDisk" :
                        ExecuteVirtualMachineDiskGetDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskListDisks" :
                        ExecuteVirtualMachineDiskListDisksMethod(argumentList);
                        break;
                    case "VirtualMachineDiskUpdateDataDisk" :
                        ExecuteVirtualMachineDiskUpdateDataDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskUpdateDisk" :
                        ExecuteVirtualMachineDiskUpdateDiskMethod(argumentList);
                        break;
                    case "VirtualMachineDiskUpdateDiskSize" :
                        ExecuteVirtualMachineDiskUpdateDiskSizeMethod(argumentList);
                        break;
                    case "VirtualMachineExtensionList" :
                        ExecuteVirtualMachineExtensionListMethod(argumentList);
                        break;
                    case "VirtualMachineExtensionListVersions" :
                        ExecuteVirtualMachineExtensionListVersionsMethod(argumentList);
                        break;
                    case "VirtualMachineCaptureOSImage" :
                        ExecuteVirtualMachineCaptureOSImageMethod(argumentList);
                        break;
                    case "VirtualMachineCaptureVMImage" :
                        ExecuteVirtualMachineCaptureVMImageMethod(argumentList);
                        break;
                    case "VirtualMachineCreate" :
                        ExecuteVirtualMachineCreateMethod(argumentList);
                        break;
                    case "VirtualMachineCreateDeployment" :
                        ExecuteVirtualMachineCreateDeploymentMethod(argumentList);
                        break;
                    case "VirtualMachineDelete" :
                        ExecuteVirtualMachineDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineGet" :
                        ExecuteVirtualMachineGetMethod(argumentList);
                        break;
                    case "VirtualMachineGetRemoteDesktopFile" :
                        ExecuteVirtualMachineGetRemoteDesktopFileMethod(argumentList);
                        break;
                    case "VirtualMachineRestart" :
                        ExecuteVirtualMachineRestartMethod(argumentList);
                        break;
                    case "VirtualMachineShutdown" :
                        ExecuteVirtualMachineShutdownMethod(argumentList);
                        break;
                    case "VirtualMachineShutdownRoles" :
                        ExecuteVirtualMachineShutdownRolesMethod(argumentList);
                        break;
                    case "VirtualMachineStart" :
                        ExecuteVirtualMachineStartMethod(argumentList);
                        break;
                    case "VirtualMachineStartRoles" :
                        ExecuteVirtualMachineStartRolesMethod(argumentList);
                        break;
                    case "VirtualMachineUpdate" :
                        ExecuteVirtualMachineUpdateMethod(argumentList);
                        break;
                    case "VirtualMachineUpdateLoadBalancedEndpointSet" :
                        ExecuteVirtualMachineUpdateLoadBalancedEndpointSetMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageCreate" :
                        ExecuteVirtualMachineOSImageCreateMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageDelete" :
                        ExecuteVirtualMachineOSImageDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageGet" :
                        ExecuteVirtualMachineOSImageGetMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageGetDetails" :
                        ExecuteVirtualMachineOSImageGetDetailsMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageList" :
                        ExecuteVirtualMachineOSImageListMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageReplicate" :
                        ExecuteVirtualMachineOSImageReplicateMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageShare" :
                        ExecuteVirtualMachineOSImageShareMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageUnreplicate" :
                        ExecuteVirtualMachineOSImageUnreplicateMethod(argumentList);
                        break;
                    case "VirtualMachineOSImageUpdate" :
                        ExecuteVirtualMachineOSImageUpdateMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageCreate" :
                        ExecuteVirtualMachineVMImageCreateMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageDelete" :
                        ExecuteVirtualMachineVMImageDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageGetDetails" :
                        ExecuteVirtualMachineVMImageGetDetailsMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageList" :
                        ExecuteVirtualMachineVMImageListMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageReplicate" :
                        ExecuteVirtualMachineVMImageReplicateMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageShare" :
                        ExecuteVirtualMachineVMImageShareMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageUnreplicate" :
                        ExecuteVirtualMachineVMImageUnreplicateMethod(argumentList);
                        break;
                    case "VirtualMachineVMImageUpdate" :
                        ExecuteVirtualMachineVMImageUpdateMethod(argumentList);
                        break;
                    default : WriteWarning("Cannot find the method by name = '" + MethodName + "'."); break;
                }
            });
        }


        public virtual object GetDynamicParameters()
        {
            switch (MethodName)
            {
                    case "DeploymentChangeConfigurationByName" : return CreateDeploymentChangeConfigurationByNameDynamicParameters();
                    case "DeploymentChangeConfigurationBySlot" : return CreateDeploymentChangeConfigurationBySlotDynamicParameters();
                    case "DeploymentCreate" : return CreateDeploymentCreateDynamicParameters();
                    case "DeploymentDeleteByName" : return CreateDeploymentDeleteByNameDynamicParameters();
                    case "DeploymentDeleteBySlot" : return CreateDeploymentDeleteBySlotDynamicParameters();
                    case "DeploymentDeleteRoleInstanceByDeploymentName" : return CreateDeploymentDeleteRoleInstanceByDeploymentNameDynamicParameters();
                    case "DeploymentDeleteRoleInstanceByDeploymentSlot" : return CreateDeploymentDeleteRoleInstanceByDeploymentSlotDynamicParameters();
                    case "DeploymentGetByName" : return CreateDeploymentGetByNameDynamicParameters();
                    case "DeploymentGetBySlot" : return CreateDeploymentGetBySlotDynamicParameters();
                    case "DeploymentGetPackageByName" : return CreateDeploymentGetPackageByNameDynamicParameters();
                    case "DeploymentGetPackageBySlot" : return CreateDeploymentGetPackageBySlotDynamicParameters();
                    case "DeploymentListEvents" : return CreateDeploymentListEventsDynamicParameters();
                    case "DeploymentListEventsBySlot" : return CreateDeploymentListEventsBySlotDynamicParameters();
                    case "DeploymentRebootRoleInstanceByDeploymentName" : return CreateDeploymentRebootRoleInstanceByDeploymentNameDynamicParameters();
                    case "DeploymentRebootRoleInstanceByDeploymentSlot" : return CreateDeploymentRebootRoleInstanceByDeploymentSlotDynamicParameters();
                    case "DeploymentRebuildRoleInstanceByDeploymentName" : return CreateDeploymentRebuildRoleInstanceByDeploymentNameDynamicParameters();
                    case "DeploymentRebuildRoleInstanceByDeploymentSlot" : return CreateDeploymentRebuildRoleInstanceByDeploymentSlotDynamicParameters();
                    case "DeploymentReimageRoleInstanceByDeploymentName" : return CreateDeploymentReimageRoleInstanceByDeploymentNameDynamicParameters();
                    case "DeploymentReimageRoleInstanceByDeploymentSlot" : return CreateDeploymentReimageRoleInstanceByDeploymentSlotDynamicParameters();
                    case "DeploymentRollbackUpdateOrUpgradeByDeploymentName" : return CreateDeploymentRollbackUpdateOrUpgradeByDeploymentNameDynamicParameters();
                    case "DeploymentRollbackUpdateOrUpgradeByDeploymentSlot" : return CreateDeploymentRollbackUpdateOrUpgradeByDeploymentSlotDynamicParameters();
                    case "DeploymentSwap" : return CreateDeploymentSwapDynamicParameters();
                    case "DeploymentUpdateStatusByDeploymentName" : return CreateDeploymentUpdateStatusByDeploymentNameDynamicParameters();
                    case "DeploymentUpdateStatusByDeploymentSlot" : return CreateDeploymentUpdateStatusByDeploymentSlotDynamicParameters();
                    case "DeploymentUpgradeByName" : return CreateDeploymentUpgradeByNameDynamicParameters();
                    case "DeploymentUpgradeBySlot" : return CreateDeploymentUpgradeBySlotDynamicParameters();
                    case "DeploymentWalkUpgradeDomainByDeploymentName" : return CreateDeploymentWalkUpgradeDomainByDeploymentNameDynamicParameters();
                    case "DeploymentWalkUpgradeDomainByDeploymentSlot" : return CreateDeploymentWalkUpgradeDomainByDeploymentSlotDynamicParameters();
                    case "DNSServerAddDNSServer" : return CreateDNSServerAddDNSServerDynamicParameters();
                    case "DNSServerDeleteDNSServer" : return CreateDNSServerDeleteDNSServerDynamicParameters();
                    case "DNSServerUpdateDNSServer" : return CreateDNSServerUpdateDNSServerDynamicParameters();
                    case "ExtensionImageRegister" : return CreateExtensionImageRegisterDynamicParameters();
                    case "ExtensionImageUnregister" : return CreateExtensionImageUnregisterDynamicParameters();
                    case "ExtensionImageUpdate" : return CreateExtensionImageUpdateDynamicParameters();
                    case "HostedServiceAddExtension" : return CreateHostedServiceAddExtensionDynamicParameters();
                    case "HostedServiceCheckNameAvailability" : return CreateHostedServiceCheckNameAvailabilityDynamicParameters();
                    case "HostedServiceCreate" : return CreateHostedServiceCreateDynamicParameters();
                    case "HostedServiceDelete" : return CreateHostedServiceDeleteDynamicParameters();
                    case "HostedServiceDeleteAll" : return CreateHostedServiceDeleteAllDynamicParameters();
                    case "HostedServiceDeleteExtension" : return CreateHostedServiceDeleteExtensionDynamicParameters();
                    case "HostedServiceGet" : return CreateHostedServiceGetDynamicParameters();
                    case "HostedServiceGetDetailed" : return CreateHostedServiceGetDetailedDynamicParameters();
                    case "HostedServiceGetExtension" : return CreateHostedServiceGetExtensionDynamicParameters();
                    case "HostedServiceList" : return CreateHostedServiceListDynamicParameters();
                    case "HostedServiceListAvailableExtensions" : return CreateHostedServiceListAvailableExtensionsDynamicParameters();
                    case "HostedServiceListExtensions" : return CreateHostedServiceListExtensionsDynamicParameters();
                    case "HostedServiceListExtensionVersions" : return CreateHostedServiceListExtensionVersionsDynamicParameters();
                    case "HostedServiceUpdate" : return CreateHostedServiceUpdateDynamicParameters();
                    case "LoadBalancerCreate" : return CreateLoadBalancerCreateDynamicParameters();
                    case "LoadBalancerDelete" : return CreateLoadBalancerDeleteDynamicParameters();
                    case "LoadBalancerUpdate" : return CreateLoadBalancerUpdateDynamicParameters();
                    case "OperatingSystemList" : return CreateOperatingSystemListDynamicParameters();
                    case "OperatingSystemListFamilies" : return CreateOperatingSystemListFamiliesDynamicParameters();
                    case "ServiceCertificateCreate" : return CreateServiceCertificateCreateDynamicParameters();
                    case "ServiceCertificateDelete" : return CreateServiceCertificateDeleteDynamicParameters();
                    case "ServiceCertificateGet" : return CreateServiceCertificateGetDynamicParameters();
                    case "ServiceCertificateList" : return CreateServiceCertificateListDynamicParameters();
                    case "VirtualMachineDiskCreateDataDisk" : return CreateVirtualMachineDiskCreateDataDiskDynamicParameters();
                    case "VirtualMachineDiskCreateDisk" : return CreateVirtualMachineDiskCreateDiskDynamicParameters();
                    case "VirtualMachineDiskDeleteDataDisk" : return CreateVirtualMachineDiskDeleteDataDiskDynamicParameters();
                    case "VirtualMachineDiskDeleteDisk" : return CreateVirtualMachineDiskDeleteDiskDynamicParameters();
                    case "VirtualMachineDiskGetDataDisk" : return CreateVirtualMachineDiskGetDataDiskDynamicParameters();
                    case "VirtualMachineDiskGetDisk" : return CreateVirtualMachineDiskGetDiskDynamicParameters();
                    case "VirtualMachineDiskListDisks" : return CreateVirtualMachineDiskListDisksDynamicParameters();
                    case "VirtualMachineDiskUpdateDataDisk" : return CreateVirtualMachineDiskUpdateDataDiskDynamicParameters();
                    case "VirtualMachineDiskUpdateDisk" : return CreateVirtualMachineDiskUpdateDiskDynamicParameters();
                    case "VirtualMachineDiskUpdateDiskSize" : return CreateVirtualMachineDiskUpdateDiskSizeDynamicParameters();
                    case "VirtualMachineExtensionList" : return CreateVirtualMachineExtensionListDynamicParameters();
                    case "VirtualMachineExtensionListVersions" : return CreateVirtualMachineExtensionListVersionsDynamicParameters();
                    case "VirtualMachineCaptureOSImage" : return CreateVirtualMachineCaptureOSImageDynamicParameters();
                    case "VirtualMachineCaptureVMImage" : return CreateVirtualMachineCaptureVMImageDynamicParameters();
                    case "VirtualMachineCreate" : return CreateVirtualMachineCreateDynamicParameters();
                    case "VirtualMachineCreateDeployment" : return CreateVirtualMachineCreateDeploymentDynamicParameters();
                    case "VirtualMachineDelete" : return CreateVirtualMachineDeleteDynamicParameters();
                    case "VirtualMachineGet" : return CreateVirtualMachineGetDynamicParameters();
                    case "VirtualMachineGetRemoteDesktopFile" : return CreateVirtualMachineGetRemoteDesktopFileDynamicParameters();
                    case "VirtualMachineRestart" : return CreateVirtualMachineRestartDynamicParameters();
                    case "VirtualMachineShutdown" : return CreateVirtualMachineShutdownDynamicParameters();
                    case "VirtualMachineShutdownRoles" : return CreateVirtualMachineShutdownRolesDynamicParameters();
                    case "VirtualMachineStart" : return CreateVirtualMachineStartDynamicParameters();
                    case "VirtualMachineStartRoles" : return CreateVirtualMachineStartRolesDynamicParameters();
                    case "VirtualMachineUpdate" : return CreateVirtualMachineUpdateDynamicParameters();
                    case "VirtualMachineUpdateLoadBalancedEndpointSet" : return CreateVirtualMachineUpdateLoadBalancedEndpointSetDynamicParameters();
                    case "VirtualMachineOSImageCreate" : return CreateVirtualMachineOSImageCreateDynamicParameters();
                    case "VirtualMachineOSImageDelete" : return CreateVirtualMachineOSImageDeleteDynamicParameters();
                    case "VirtualMachineOSImageGet" : return CreateVirtualMachineOSImageGetDynamicParameters();
                    case "VirtualMachineOSImageGetDetails" : return CreateVirtualMachineOSImageGetDetailsDynamicParameters();
                    case "VirtualMachineOSImageList" : return CreateVirtualMachineOSImageListDynamicParameters();
                    case "VirtualMachineOSImageReplicate" : return CreateVirtualMachineOSImageReplicateDynamicParameters();
                    case "VirtualMachineOSImageShare" : return CreateVirtualMachineOSImageShareDynamicParameters();
                    case "VirtualMachineOSImageUnreplicate" : return CreateVirtualMachineOSImageUnreplicateDynamicParameters();
                    case "VirtualMachineOSImageUpdate" : return CreateVirtualMachineOSImageUpdateDynamicParameters();
                    case "VirtualMachineVMImageCreate" : return CreateVirtualMachineVMImageCreateDynamicParameters();
                    case "VirtualMachineVMImageDelete" : return CreateVirtualMachineVMImageDeleteDynamicParameters();
                    case "VirtualMachineVMImageGetDetails" : return CreateVirtualMachineVMImageGetDetailsDynamicParameters();
                    case "VirtualMachineVMImageList" : return CreateVirtualMachineVMImageListDynamicParameters();
                    case "VirtualMachineVMImageReplicate" : return CreateVirtualMachineVMImageReplicateDynamicParameters();
                    case "VirtualMachineVMImageShare" : return CreateVirtualMachineVMImageShareDynamicParameters();
                    case "VirtualMachineVMImageUnreplicate" : return CreateVirtualMachineVMImageUnreplicateDynamicParameters();
                    case "VirtualMachineVMImageUpdate" : return CreateVirtualMachineVMImageUpdateDynamicParameters();
                    default : break;
            }

            return null;
        }

    }
}
