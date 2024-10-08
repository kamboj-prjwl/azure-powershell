// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Auth Secrets for Scale Rule</summary>
    public partial class ScaleRuleAuth :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IScaleRuleAuth,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IScaleRuleAuthInternal
    {

        /// <summary>Backing field for <see cref="SecretRef" /> property.</summary>
        private string _secretRef;

        /// <summary>Name of the secret from which to pull the auth params.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string SecretRef { get => this._secretRef; set => this._secretRef = value; }

        /// <summary>Backing field for <see cref="TriggerParameter" /> property.</summary>
        private string _triggerParameter;

        /// <summary>Trigger Parameter that uses the secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string TriggerParameter { get => this._triggerParameter; set => this._triggerParameter = value; }

        /// <summary>Creates an new <see cref="ScaleRuleAuth" /> instance.</summary>
        public ScaleRuleAuth()
        {

        }
    }
    /// Auth Secrets for Scale Rule
    public partial interface IScaleRuleAuth :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Name of the secret from which to pull the auth params.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the secret from which to pull the auth params.",
        SerializedName = @"secretRef",
        PossibleTypes = new [] { typeof(string) })]
        string SecretRef { get; set; }
        /// <summary>Trigger Parameter that uses the secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Trigger Parameter that uses the secret",
        SerializedName = @"triggerParameter",
        PossibleTypes = new [] { typeof(string) })]
        string TriggerParameter { get; set; }

    }
    /// Auth Secrets for Scale Rule
    internal partial interface IScaleRuleAuthInternal

    {
        /// <summary>Name of the secret from which to pull the auth params.</summary>
        string SecretRef { get; set; }
        /// <summary>Trigger Parameter that uses the secret</summary>
        string TriggerParameter { get; set; }

    }
}