// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Search.Models
{

    /// <summary>
    /// Defines values for SharedPrivateLinkResourceProvisioningState.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SharedPrivateLinkResourceProvisioningState
    {
        [System.Runtime.Serialization.EnumMember(Value = "Updating")]
        Updating,
        [System.Runtime.Serialization.EnumMember(Value = "Deleting")]
        Deleting,
        [System.Runtime.Serialization.EnumMember(Value = "Failed")]
        Failed,
        [System.Runtime.Serialization.EnumMember(Value = "Succeeded")]
        Succeeded,
        [System.Runtime.Serialization.EnumMember(Value = "Incomplete")]
        Incomplete
    }
    internal static class SharedPrivateLinkResourceProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this SharedPrivateLinkResourceProvisioningState? value)
        {
            return value == null ? null : ((SharedPrivateLinkResourceProvisioningState)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this SharedPrivateLinkResourceProvisioningState value)
        {
            switch( value )
            {
                case SharedPrivateLinkResourceProvisioningState.Updating:
                    return "Updating";
                case SharedPrivateLinkResourceProvisioningState.Deleting:
                    return "Deleting";
                case SharedPrivateLinkResourceProvisioningState.Failed:
                    return "Failed";
                case SharedPrivateLinkResourceProvisioningState.Succeeded:
                    return "Succeeded";
                case SharedPrivateLinkResourceProvisioningState.Incomplete:
                    return "Incomplete";
            }
            return null;
        }
        internal static SharedPrivateLinkResourceProvisioningState? ParseSharedPrivateLinkResourceProvisioningState(this string value)
        {
            switch( value )
            {
                case "Updating":
                    return SharedPrivateLinkResourceProvisioningState.Updating;
                case "Deleting":
                    return SharedPrivateLinkResourceProvisioningState.Deleting;
                case "Failed":
                    return SharedPrivateLinkResourceProvisioningState.Failed;
                case "Succeeded":
                    return SharedPrivateLinkResourceProvisioningState.Succeeded;
                case "Incomplete":
                    return SharedPrivateLinkResourceProvisioningState.Incomplete;
            }
            return null;
        }
    }
}