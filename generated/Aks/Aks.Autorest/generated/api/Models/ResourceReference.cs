// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>A reference to an Azure resource.</summary>
    public partial class ResourceReference :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IResourceReference,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IResourceReferenceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The fully qualified Azure resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="ResourceReference" /> instance.</summary>
        public ResourceReference()
        {

        }
    }
    /// A reference to an Azure resource.
    public partial interface IResourceReference :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>The fully qualified Azure resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified Azure resource id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// A reference to an Azure resource.
    internal partial interface IResourceReferenceInternal

    {
        /// <summary>The fully qualified Azure resource id.</summary>
        string Id { get; set; }

    }
}