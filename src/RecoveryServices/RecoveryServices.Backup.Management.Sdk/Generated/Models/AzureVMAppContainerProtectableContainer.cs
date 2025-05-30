// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Azure workload-specific container
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMAppContainer")]
    public partial class AzureVMAppContainerProtectableContainer : ProtectableContainer
    {
        /// <summary>
        /// Initializes a new instance of the AzureVMAppContainerProtectableContainer class.
        /// </summary>
        public AzureVMAppContainerProtectableContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureVMAppContainerProtectableContainer class.
        /// </summary>

        /// <param name="friendlyName">Friendly name of the container.
        /// </param>

        /// <param name="backupManagementType">Type of backup management for the container.
        /// Possible values include: &#39;Invalid&#39;, &#39;AzureIaasVM&#39;, &#39;MAB&#39;, &#39;DPM&#39;,
        /// &#39;AzureBackupServer&#39;, &#39;AzureSql&#39;, &#39;AzureStorage&#39;, &#39;AzureWorkload&#39;,
        /// &#39;DefaultBackup&#39;</param>

        /// <param name="healthStatus">Status of health of the container.
        /// </param>

        /// <param name="containerId">Fabric Id of the container such as ARM Id.
        /// </param>
        public AzureVMAppContainerProtectableContainer(string friendlyName = default(string), string backupManagementType = default(string), string healthStatus = default(string), string containerId = default(string))

        : base(friendlyName, backupManagementType, healthStatus, containerId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}