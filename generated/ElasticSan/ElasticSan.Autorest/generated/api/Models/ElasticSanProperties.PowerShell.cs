// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.PowerShell;

    /// <summary>Elastic San response properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ElasticSanPropertiesTypeConverter))]
    public partial class ElasticSanProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ElasticSanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ElasticSanProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ElasticSanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ElasticSanProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ElasticSanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ElasticSanProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).AvailabilityZone = (System.Collections.Generic.List<string>) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).AvailabilityZone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("BaseSizeTiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).BaseSizeTiB = (long?) content.GetValueForProperty("BaseSizeTiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).BaseSizeTiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExtendedCapacitySizeTiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ExtendedCapacitySizeTiB = (long?) content.GetValueForProperty("ExtendedCapacitySizeTiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ExtendedCapacitySizeTiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalVolumeSizeGiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalVolumeSizeGiB = (long?) content.GetValueForProperty("TotalVolumeSizeGiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalVolumeSizeGiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VolumeGroupCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).VolumeGroupCount = (long?) content.GetValueForProperty("VolumeGroupCount",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).VolumeGroupCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalIops"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalIops = (long?) content.GetValueForProperty("TotalIops",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalIops, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalMBps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalMBps = (long?) content.GetValueForProperty("TotalMBps",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalMBps, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalSizeTiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalSizeTiB = (long?) content.GetValueForProperty("TotalSizeTiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalSizeTiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuTier, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ElasticSanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ElasticSanProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).AvailabilityZone = (System.Collections.Generic.List<string>) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).AvailabilityZone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("BaseSizeTiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).BaseSizeTiB = (long?) content.GetValueForProperty("BaseSizeTiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).BaseSizeTiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExtendedCapacitySizeTiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ExtendedCapacitySizeTiB = (long?) content.GetValueForProperty("ExtendedCapacitySizeTiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).ExtendedCapacitySizeTiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalVolumeSizeGiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalVolumeSizeGiB = (long?) content.GetValueForProperty("TotalVolumeSizeGiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalVolumeSizeGiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("VolumeGroupCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).VolumeGroupCount = (long?) content.GetValueForProperty("VolumeGroupCount",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).VolumeGroupCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalIops"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalIops = (long?) content.GetValueForProperty("TotalIops",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalIops, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalMBps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalMBps = (long?) content.GetValueForProperty("TotalMBps",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalMBps, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TotalSizeTiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalSizeTiB = (long?) content.GetValueForProperty("TotalSizeTiB",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).TotalSizeTiB, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanPropertiesInternal)this).SkuTier, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ElasticSanProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ElasticSanProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Elastic San response properties.
    [System.ComponentModel.TypeConverter(typeof(ElasticSanPropertiesTypeConverter))]
    public partial interface IElasticSanProperties

    {

    }
}