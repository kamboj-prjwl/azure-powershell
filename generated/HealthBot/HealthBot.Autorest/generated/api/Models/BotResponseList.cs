// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Runtime.Extensions;

    /// <summary>The list of Healthbot operation response.</summary>
    public partial class BotResponseList :
        Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IBotResponseList,
        Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IBotResponseListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IBotResponseListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IHealthBot> Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IBotResponseListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of bot service resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthBot.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IHealthBot> _value;

        /// <summary>Gets the list of Healthbot results and their properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthBot.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IHealthBot> Value { get => this._value; }

        /// <summary>Creates an new <see cref="BotResponseList" /> instance.</summary>
        public BotResponseList()
        {

        }
    }
    /// The list of Healthbot operation response.
    public partial interface IBotResponseList :
        Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of bot service resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The link used to get the next page of bot service resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Gets the list of Healthbot results and their properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the list of Healthbot results and their properties.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IHealthBot) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IHealthBot> Value { get;  }

    }
    /// The list of Healthbot operation response.
    internal partial interface IBotResponseListInternal

    {
        /// <summary>The link used to get the next page of bot service resources.</summary>
        string NextLink { get; set; }
        /// <summary>Gets the list of Healthbot results and their properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthBot.Models.IHealthBot> Value { get; set; }

    }
}