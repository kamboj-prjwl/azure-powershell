// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Details of capabilities available to a SKU in specific zones</summary>
    public partial class ResourceSkuZoneDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceSkuZoneDetails,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceSkuZoneDetailsInternal
    {

        /// <summary>Backing field for <see cref="Capability" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceSkuCapabilities> _capability;

        /// <summary>
        /// Gets a list of capabilities that are available for the SKU in the
        /// specified list of zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceSkuCapabilities> Capability { get => this._capability; set => this._capability = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private System.Collections.Generic.List<string> _name;

        /// <summary>
        /// Gets the set of zones that the SKU is available in with the
        /// specified capabilities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ResourceSkuZoneDetails" /> instance.</summary>
        public ResourceSkuZoneDetails()
        {

        }
    }
    /// Details of capabilities available to a SKU in specific zones
    public partial interface IResourceSkuZoneDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets a list of capabilities that are available for the SKU in the
        /// specified list of zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets a list of capabilities that are available for the SKU in the
        specified list of zones.",
        SerializedName = @"capabilities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceSkuCapabilities) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceSkuCapabilities> Capability { get; set; }
        /// <summary>
        /// Gets the set of zones that the SKU is available in with the
        /// specified capabilities.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets the set of zones that the SKU is available in with the
        specified capabilities.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Name { get; set; }

    }
    /// Details of capabilities available to a SKU in specific zones
    internal partial interface IResourceSkuZoneDetailsInternal

    {
        /// <summary>
        /// Gets a list of capabilities that are available for the SKU in the
        /// specified list of zones.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceSkuCapabilities> Capability { get; set; }
        /// <summary>
        /// Gets the set of zones that the SKU is available in with the
        /// specified capabilities.
        /// </summary>
        System.Collections.Generic.List<string> Name { get; set; }

    }
}