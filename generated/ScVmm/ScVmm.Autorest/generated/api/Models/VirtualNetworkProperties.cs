// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>Defines the resource properties.</summary>
    public partial class VirtualNetworkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualNetworkProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualNetworkPropertiesInternal
    {

        /// <summary>Backing field for <see cref="InventoryItemId" /> property.</summary>
        private string _inventoryItemId;

        /// <summary>Gets or sets the inventory Item ID for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string InventoryItemId { get => this._inventoryItemId; set => this._inventoryItemId = value; }

        /// <summary>Internal Acessors for NetworkName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualNetworkPropertiesInternal.NetworkName { get => this._networkName; set { {_networkName = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualNetworkPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        /// <summary>Name of the virtual network in vmmServer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>Unique ID of the virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; set => this._uuid = value; }

        /// <summary>Backing field for <see cref="VmmServerId" /> property.</summary>
        private string _vmmServerId;

        /// <summary>ARM Id of the vmmServer resource in which this resource resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string VmmServerId { get => this._vmmServerId; set => this._vmmServerId = value; }

        /// <summary>Creates an new <see cref="VirtualNetworkProperties" /> instance.</summary>
        public VirtualNetworkProperties()
        {

        }
    }
    /// Defines the resource properties.
    public partial interface IVirtualNetworkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the inventory Item ID for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the inventory Item ID for the resource.",
        SerializedName = @"inventoryItemId",
        PossibleTypes = new [] { typeof(string) })]
        string InventoryItemId { get; set; }
        /// <summary>Name of the virtual network in vmmServer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the virtual network in vmmServer.",
        SerializedName = @"networkName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get;  }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted", "Created")]
        string ProvisioningState { get;  }
        /// <summary>Unique ID of the virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique ID of the virtual network.",
        SerializedName = @"uuid",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get; set; }
        /// <summary>ARM Id of the vmmServer resource in which this resource resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM Id of the vmmServer resource in which this resource resides.",
        SerializedName = @"vmmServerId",
        PossibleTypes = new [] { typeof(string) })]
        string VmmServerId { get; set; }

    }
    /// Defines the resource properties.
    internal partial interface IVirtualNetworkPropertiesInternal

    {
        /// <summary>Gets or sets the inventory Item ID for the resource.</summary>
        string InventoryItemId { get; set; }
        /// <summary>Name of the virtual network in vmmServer.</summary>
        string NetworkName { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted", "Created")]
        string ProvisioningState { get; set; }
        /// <summary>Unique ID of the virtual network.</summary>
        string Uuid { get; set; }
        /// <summary>ARM Id of the vmmServer resource in which this resource resides.</summary>
        string VmmServerId { get; set; }

    }
}