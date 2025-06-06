// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>Microsoft Fabric endpoint Names properties</summary>
    public partial class DataflowEndpointFabricOneLakeNames
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject into a new instance of <see cref="DataflowEndpointFabricOneLakeNames" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DataflowEndpointFabricOneLakeNames(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_lakehouseName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonString>("lakehouseName"), out var __jsonLakehouseName) ? (string)__jsonLakehouseName : (string)_lakehouseName;}
            {_workspaceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonString>("workspaceName"), out var __jsonWorkspaceName) ? (string)__jsonWorkspaceName : (string)_workspaceName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointFabricOneLakeNames.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointFabricOneLakeNames.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointFabricOneLakeNames FromJson(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject json ? new DataflowEndpointFabricOneLakeNames(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DataflowEndpointFabricOneLakeNames" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DataflowEndpointFabricOneLakeNames" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._lakehouseName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonString(this._lakehouseName.ToString()) : null, "lakehouseName" ,container.Add );
            AddIf( null != (((object)this._workspaceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Json.JsonString(this._workspaceName.ToString()) : null, "workspaceName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}