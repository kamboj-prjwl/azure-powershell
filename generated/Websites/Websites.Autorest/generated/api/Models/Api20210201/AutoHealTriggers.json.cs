// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>Triggers for auto-heal.</summary>
    public partial class AutoHealTriggers
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject into a new instance of <see cref="AutoHealTriggers" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AutoHealTriggers(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_request = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("requests"), out var __jsonRequests) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RequestsBasedTrigger.FromJson(__jsonRequests) : Request;}
            {_slowRequest = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("slowRequests"), out var __jsonSlowRequests) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlowRequestsBasedTrigger.FromJson(__jsonSlowRequests) : SlowRequest;}
            {_privateBytesInKb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNumber>("privateBytesInKB"), out var __jsonPrivateBytesInKb) ? (int?)__jsonPrivateBytesInKb : PrivateBytesInKb;}
            {_statusCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray>("statusCodes"), out var __jsonStatusCodes) ? If( __jsonStatusCodes as Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IStatusCodesBasedTrigger[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IStatusCodesBasedTrigger) (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.StatusCodesBasedTrigger.FromJson(__u) )) ))() : null : StatusCode;}
            {_slowRequestsWithPath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray>("slowRequestsWithPath"), out var __jsonSlowRequestsWithPath) ? If( __jsonSlowRequestsWithPath as Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlowRequestsBasedTrigger[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlowRequestsBasedTrigger) (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlowRequestsBasedTrigger.FromJson(__p) )) ))() : null : SlowRequestsWithPath;}
            {_statusCodesRange = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray>("statusCodesRange"), out var __jsonStatusCodesRange) ? If( __jsonStatusCodesRange as Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IStatusCodesRangeBasedTrigger[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IStatusCodesRangeBasedTrigger) (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.StatusCodesRangeBasedTrigger.FromJson(__k) )) ))() : null : StatusCodesRange;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAutoHealTriggers.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAutoHealTriggers.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAutoHealTriggers FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json ? new AutoHealTriggers(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AutoHealTriggers" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AutoHealTriggers" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._request ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._request.ToJson(null,serializationMode) : null, "requests" ,container.Add );
            AddIf( null != this._slowRequest ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._slowRequest.ToJson(null,serializationMode) : null, "slowRequests" ,container.Add );
            AddIf( null != this._privateBytesInKb ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNumber((int)this._privateBytesInKb) : null, "privateBytesInKB" ,container.Add );
            if (null != this._statusCode)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.XNodeArray();
                foreach( var __x in this._statusCode )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("statusCodes",__w);
            }
            if (null != this._slowRequestsWithPath)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.XNodeArray();
                foreach( var __s in this._slowRequestsWithPath )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("slowRequestsWithPath",__r);
            }
            if (null != this._statusCodesRange)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.XNodeArray();
                foreach( var __n in this._statusCodesRange )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("statusCodesRange",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}