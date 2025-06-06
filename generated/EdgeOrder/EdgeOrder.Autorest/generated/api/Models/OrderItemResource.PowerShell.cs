// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.PowerShell;

    /// <summary>Represents order item contract</summary>
    [System.ComponentModel.TypeConverter(typeof(OrderItemResourceTypeConverter))]
    public partial class OrderItemResource
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrderItemResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrderItemResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrderItemResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OrderItemResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrderItemResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AddressDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetails) content.GetValueForProperty("AddressDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrderItemDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderItemDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemDetails) content.GetValueForProperty("OrderItemDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderItemDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OrderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderId = (string) content.GetValueForProperty("OrderId",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderId, global::System.Convert.ToString);
            }
            if (content.Contains("AddressDetailForwardAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailForwardAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("AddressDetailForwardAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailForwardAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddressDetailReturnAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailReturnAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("AddressDetailReturnAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailReturnAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ForwardAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ForwardAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ReturnAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ReturnAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressValidationStatus = (string) content.GetValueForProperty("ForwardAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressValidationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressValidationStatus = (string) content.GetValueForProperty("ReturnAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressValidationStatus, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrderItemResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AddressDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetails) content.GetValueForProperty("AddressDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrderItemDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderItemDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemDetails) content.GetValueForProperty("OrderItemDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderItemDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.OrderItemDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OrderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderId = (string) content.GetValueForProperty("OrderId",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).OrderId, global::System.Convert.ToString);
            }
            if (content.Contains("AddressDetailForwardAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailForwardAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("AddressDetailForwardAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailForwardAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddressDetailReturnAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailReturnAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("AddressDetailReturnAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).AddressDetailReturnAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ForwardAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ForwardAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ReturnAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ReturnAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressValidationStatus = (string) content.GetValueForProperty("ForwardAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ForwardAddressValidationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressValidationStatus = (string) content.GetValueForProperty("ReturnAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderItemResourceInternal)this).ReturnAddressValidationStatus, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Represents order item contract
    [System.ComponentModel.TypeConverter(typeof(OrderItemResourceTypeConverter))]
    public partial interface IOrderItemResource

    {

    }
}