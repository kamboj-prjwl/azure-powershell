// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines rules that scrub sensitive fields in the Azure Front Door profile logs.</summary>
    public partial class ProfileLogScrubbing :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileLogScrubbing,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileLogScrubbingInternal
    {

        /// <summary>Backing field for <see cref="ScrubbingRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules> _scrubbingRule;

        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules> ScrubbingRule { get => this._scrubbingRule; set => this._scrubbingRule = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="ProfileLogScrubbing" /> instance.</summary>
        public ProfileLogScrubbing()
        {

        }
    }
    /// Defines rules that scrub sensitive fields in the Azure Front Door profile logs.
    public partial interface IProfileLogScrubbing :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of log scrubbing rules applied to the Azure Front Door profile logs.",
        SerializedName = @"scrubbingRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules> ScrubbingRule { get; set; }
        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of the log scrubbing config. Default value is Enabled.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string State { get; set; }

    }
    /// Defines rules that scrub sensitive fields in the Azure Front Door profile logs.
    internal partial interface IProfileLogScrubbingInternal

    {
        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileScrubbingRules> ScrubbingRule { get; set; }
        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string State { get; set; }

    }
}