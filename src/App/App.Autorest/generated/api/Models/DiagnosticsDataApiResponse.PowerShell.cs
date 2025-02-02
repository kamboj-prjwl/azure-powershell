// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>Diagnostics data returned from a detector</summary>
    [System.ComponentModel.TypeConverter(typeof(DiagnosticsDataApiResponseTypeConverter))]
    public partial class DiagnosticsDataApiResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticsDataApiResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DiagnosticsDataApiResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticsDataApiResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DiagnosticsDataApiResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticsDataApiResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DiagnosticsDataApiResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Table"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).Table = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseObject) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).Table, Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticDataTableResponseObjectTypeConverter.ConvertFrom);
            }
            if (content.Contains("RenderingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingProperty = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticRendering) content.GetValueForProperty("RenderingProperty",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingProperty, Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticRenderingTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableName = (string) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableName, global::System.Convert.ToString);
            }
            if (content.Contains("TableColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableColumn = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn>) content.GetValueForProperty("TableColumn",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableColumn, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticDataTableResponseColumnTypeConverter.ConvertFrom));
            }
            if (content.Contains("TableRow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableRow = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny>) content.GetValueForProperty("TableRow",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableRow, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.AnyTypeConverter.ConvertFrom));
            }
            if (content.Contains("RenderingPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyType = (int?) content.GetValueForProperty("RenderingPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyType, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RenderingPropertyTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyTitle = (string) content.GetValueForProperty("RenderingPropertyTitle",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyTitle, global::System.Convert.ToString);
            }
            if (content.Contains("RenderingPropertyDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyDescription = (string) content.GetValueForProperty("RenderingPropertyDescription",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyDescription, global::System.Convert.ToString);
            }
            if (content.Contains("RenderingPropertyIsVisible"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyIsVisible = (bool?) content.GetValueForProperty("RenderingPropertyIsVisible",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyIsVisible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticsDataApiResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DiagnosticsDataApiResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Table"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).Table = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseObject) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).Table, Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticDataTableResponseObjectTypeConverter.ConvertFrom);
            }
            if (content.Contains("RenderingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingProperty = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticRendering) content.GetValueForProperty("RenderingProperty",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingProperty, Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticRenderingTypeConverter.ConvertFrom);
            }
            if (content.Contains("TableName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableName = (string) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableName, global::System.Convert.ToString);
            }
            if (content.Contains("TableColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableColumn = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn>) content.GetValueForProperty("TableColumn",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableColumn, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.DiagnosticDataTableResponseColumnTypeConverter.ConvertFrom));
            }
            if (content.Contains("TableRow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableRow = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny>) content.GetValueForProperty("TableRow",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).TableRow, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.AnyTypeConverter.ConvertFrom));
            }
            if (content.Contains("RenderingPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyType = (int?) content.GetValueForProperty("RenderingPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyType, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RenderingPropertyTitle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyTitle = (string) content.GetValueForProperty("RenderingPropertyTitle",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyTitle, global::System.Convert.ToString);
            }
            if (content.Contains("RenderingPropertyDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyDescription = (string) content.GetValueForProperty("RenderingPropertyDescription",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyDescription, global::System.Convert.ToString);
            }
            if (content.Contains("RenderingPropertyIsVisible"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyIsVisible = (bool?) content.GetValueForProperty("RenderingPropertyIsVisible",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponseInternal)this).RenderingPropertyIsVisible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DiagnosticsDataApiResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DiagnosticsDataApiResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticsDataApiResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Diagnostics data returned from a detector
    [System.ComponentModel.TypeConverter(typeof(DiagnosticsDataApiResponseTypeConverter))]
    public partial interface IDiagnosticsDataApiResponse

    {

    }
}