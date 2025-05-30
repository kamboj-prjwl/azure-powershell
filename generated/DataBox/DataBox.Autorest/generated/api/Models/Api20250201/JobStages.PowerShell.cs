// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Job stages.</summary>
    [System.ComponentModel.TypeConverter(typeof(JobStagesTypeConverter))]
    public partial class JobStages
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobStages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStages" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStages DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobStages(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobStages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStages" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStages DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobStages(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobStages" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="JobStages" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStages FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobStages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobStages(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageName = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName?) content.GetValueForProperty("StageName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageName, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName.CreateFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("StageStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageStatus?) content.GetValueForProperty("StageStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageStatus, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageStatus.CreateFrom);
            }
            if (content.Contains("StageTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageTime = (global::System.DateTime?) content.GetValueForProperty("StageTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("JobStageDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).JobStageDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny) content.GetValueForProperty("JobStageDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).JobStageDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("DelayInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DelayInformation = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobDelayDetails[]) content.GetValueForProperty("DelayInformation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DelayInformation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobDelayDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobDelayDetailsTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobStages"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobStages(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageName = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName?) content.GetValueForProperty("StageName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageName, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName.CreateFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("StageStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageStatus?) content.GetValueForProperty("StageStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageStatus, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageStatus.CreateFrom);
            }
            if (content.Contains("StageTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageTime = (global::System.DateTime?) content.GetValueForProperty("StageTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).StageTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("JobStageDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).JobStageDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny) content.GetValueForProperty("JobStageDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).JobStageDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("DelayInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DelayInformation = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobDelayDetails[]) content.GetValueForProperty("DelayInformation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobStagesInternal)this).DelayInformation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobDelayDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobDelayDetailsTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Job stages.
    [System.ComponentModel.TypeConverter(typeof(JobStagesTypeConverter))]
    public partial interface IJobStages

    {

    }
}