// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>
    /// The definition of a filtering tag. Filtering tags are used for capturing resources and include/exclude them from being
    /// monitored.
    /// </summary>
    public partial class FilteringTag :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IFilteringTag,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IFilteringTagInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>Valid actions for a filtering tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name (also known as the key) of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="FilteringTag" /> instance.</summary>
        public FilteringTag()
        {

        }
    }
    /// The definition of a filtering tag. Filtering tags are used for capturing resources and include/exclude them from being
    /// monitored.
    public partial interface IFilteringTag :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>Valid actions for a filtering tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Valid actions for a filtering tag.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Elastic.PSArgumentCompleterAttribute("Include", "Exclude")]
        string Action { get; set; }
        /// <summary>The name (also known as the key) of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name (also known as the key) of the tag.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The value of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The value of the tag.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// The definition of a filtering tag. Filtering tags are used for capturing resources and include/exclude them from being
    /// monitored.
    internal partial interface IFilteringTagInternal

    {
        /// <summary>Valid actions for a filtering tag.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Elastic.PSArgumentCompleterAttribute("Include", "Exclude")]
        string Action { get; set; }
        /// <summary>The name (also known as the key) of the tag.</summary>
        string Name { get; set; }
        /// <summary>The value of the tag.</summary>
        string Value { get; set; }

    }
}