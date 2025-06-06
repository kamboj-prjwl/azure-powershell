// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object containing endpoint update parameters.</summary>
    public partial class AfdEndpointPropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="EnabledState" /> property.</summary>
        private string _enabledState;

        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string EnabledState { get => this._enabledState; set => this._enabledState = value; }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal.ProfileName { get => this._profileName; set { {_profileName = value;} } }

        /// <summary>Backing field for <see cref="ProfileName" /> property.</summary>
        private string _profileName;

        /// <summary>The name of the profile which holds the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ProfileName { get => this._profileName; }

        /// <summary>Creates an new <see cref="AfdEndpointPropertiesUpdateParameters" /> instance.</summary>
        public AfdEndpointPropertiesUpdateParameters()
        {

        }
    }
    /// The JSON object containing endpoint update parameters.
    public partial interface IAfdEndpointPropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'",
        SerializedName = @"enabledState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EnabledState { get; set; }
        /// <summary>The name of the profile which holds the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the profile which holds the endpoint.",
        SerializedName = @"profileName",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileName { get;  }

    }
    /// The JSON object containing endpoint update parameters.
    internal partial interface IAfdEndpointPropertiesUpdateParametersInternal

    {
        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EnabledState { get; set; }
        /// <summary>The name of the profile which holds the endpoint.</summary>
        string ProfileName { get; set; }

    }
}