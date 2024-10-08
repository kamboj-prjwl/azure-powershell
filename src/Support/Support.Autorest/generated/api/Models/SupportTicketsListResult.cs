// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Support.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Extensions;

    /// <summary>Object that represents a collection of SupportTicket resources.</summary>
    public partial class SupportTicketsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ISupportTicketsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ISupportTicketsListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URI to fetch the next page of SupportTicket resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ISupportTicketDetails> _value;

        /// <summary>List of SupportTicket resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ISupportTicketDetails> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SupportTicketsListResult" /> instance.</summary>
        public SupportTicketsListResult()
        {

        }
    }
    /// Object that represents a collection of SupportTicket resources.
    public partial interface ISupportTicketsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.IJsonSerializable
    {
        /// <summary>The URI to fetch the next page of SupportTicket resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URI to fetch the next page of SupportTicket resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of SupportTicket resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of SupportTicket resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ISupportTicketDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ISupportTicketDetails> Value { get; set; }

    }
    /// Object that represents a collection of SupportTicket resources.
    internal partial interface ISupportTicketsListResultInternal

    {
        /// <summary>The URI to fetch the next page of SupportTicket resources.</summary>
        string NextLink { get; set; }
        /// <summary>List of SupportTicket resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Support.Models.ISupportTicketDetails> Value { get; set; }

    }
}