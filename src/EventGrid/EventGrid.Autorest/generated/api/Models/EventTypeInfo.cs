// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>The event type information for Channels.</summary>
    public partial class EventTypeInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfo,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInternal
    {

        /// <summary>Backing field for <see cref="InlineEventType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes _inlineEventType;

        /// <summary>
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the
        /// name of the event.
        /// An example of a valid inline event name is "Contoso.OrderCreated".
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
        /// event type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes InlineEventType { get => (this._inlineEventType = this._inlineEventType ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.EventTypeInfoInlineEventTypes()); set => this._inlineEventType = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>The kind of event type used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Creates an new <see cref="EventTypeInfo" /> instance.</summary>
        public EventTypeInfo()
        {

        }
    }
    /// The event type information for Channels.
    public partial interface IEventTypeInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the
        /// name of the event.
        /// An example of a valid inline event name is "Contoso.OrderCreated".
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
        /// event type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A collection of inline event types for the resource. The inline event type keys are of type string which represents the name of the event.
        An example of a valid inline event name is ""Contoso.OrderCreated"".
        The inline event type values are of type InlineEventProperties and will contain additional information for every inline event type.",
        SerializedName = @"inlineEventTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes InlineEventType { get; set; }
        /// <summary>The kind of event type used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The kind of event type used.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Inline")]
        string Kind { get; set; }

    }
    /// The event type information for Channels.
    internal partial interface IEventTypeInfoInternal

    {
        /// <summary>
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the
        /// name of the event.
        /// An example of a valid inline event name is "Contoso.OrderCreated".
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
        /// event type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes InlineEventType { get; set; }
        /// <summary>The kind of event type used.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Inline")]
        string Kind { get; set; }

    }
}