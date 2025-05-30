// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Private endpoint connection proxy object properties.</summary>
    public partial class ConnectionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IConnectionDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IConnectionDetailsInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>Group ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Connection details ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="LinkIdentifier" /> property.</summary>
        private string _linkIdentifier;

        /// <summary>Link ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string LinkIdentifier { get => this._linkIdentifier; }

        /// <summary>Backing field for <see cref="MemberName" /> property.</summary>
        private string _memberName;

        /// <summary>Member name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string MemberName { get => this._memberName; }

        /// <summary>Internal Acessors for GroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IConnectionDetailsInternal.GroupId { get => this._groupId; set { {_groupId = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IConnectionDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LinkIdentifier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IConnectionDetailsInternal.LinkIdentifier { get => this._linkIdentifier; set { {_linkIdentifier = value;} } }

        /// <summary>Internal Acessors for MemberName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IConnectionDetailsInternal.MemberName { get => this._memberName; set { {_memberName = value;} } }

        /// <summary>Internal Acessors for PrivateIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IConnectionDetailsInternal.PrivateIPAddress { get => this._privateIPAddress; set { {_privateIPAddress = value;} } }

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private string _privateIPAddress;

        /// <summary>Private IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string PrivateIPAddress { get => this._privateIPAddress; }

        /// <summary>Creates an new <see cref="ConnectionDetails" /> instance.</summary>
        public ConnectionDetails()
        {

        }
    }
    /// Private endpoint connection proxy object properties.
    public partial interface IConnectionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable
    {
        /// <summary>Group ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Group ID.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get;  }
        /// <summary>Connection details ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Connection details ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Link ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Link ID.",
        SerializedName = @"linkIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string LinkIdentifier { get;  }
        /// <summary>Member name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Member name.",
        SerializedName = @"memberName",
        PossibleTypes = new [] { typeof(string) })]
        string MemberName { get;  }
        /// <summary>Private IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Private IP address.",
        SerializedName = @"privateIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddress { get;  }

    }
    /// Private endpoint connection proxy object properties.
    internal partial interface IConnectionDetailsInternal

    {
        /// <summary>Group ID.</summary>
        string GroupId { get; set; }
        /// <summary>Connection details ID.</summary>
        string Id { get; set; }
        /// <summary>Link ID.</summary>
        string LinkIdentifier { get; set; }
        /// <summary>Member name.</summary>
        string MemberName { get; set; }
        /// <summary>Private IP address.</summary>
        string PrivateIPAddress { get; set; }

    }
}