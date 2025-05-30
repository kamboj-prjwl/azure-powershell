// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.PowerShell;

    /// <summary>Properties specific to Partner's organization</summary>
    [System.ComponentModel.TypeConverter(typeof(LiftrBaseDataPartnerOrganizationPropertiesTypeConverter))]
    public partial class LiftrBaseDataPartnerOrganizationProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.LiftrBaseDataPartnerOrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LiftrBaseDataPartnerOrganizationProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.LiftrBaseDataPartnerOrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LiftrBaseDataPartnerOrganizationProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LiftrBaseDataPartnerOrganizationProperties" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="LiftrBaseDataPartnerOrganizationProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.LiftrBaseDataPartnerOrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LiftrBaseDataPartnerOrganizationProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseSingleSignOnProperties) content.GetValueForProperty("SingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.LiftrBaseSingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationId = (string) content.GetValueForProperty("OrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationName = (string) content.GetValueForProperty("OrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.LiftrBaseDataPartnerOrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LiftrBaseDataPartnerOrganizationProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseSingleSignOnProperties) content.GetValueForProperty("SingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.LiftrBaseSingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("OrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationId = (string) content.GetValueForProperty("OrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationName = (string) content.GetValueForProperty("OrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).OrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyAadDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyAadDomain = (System.Collections.Generic.List<string>) content.GetValueForProperty("SingleSignOnPropertyAadDomain",((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ILiftrBaseDataPartnerOrganizationPropertiesInternal)this).SingleSignOnPropertyAadDomain, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties specific to Partner's organization
    [System.ComponentModel.TypeConverter(typeof(LiftrBaseDataPartnerOrganizationPropertiesTypeConverter))]
    public partial interface ILiftrBaseDataPartnerOrganizationProperties

    {

    }
}