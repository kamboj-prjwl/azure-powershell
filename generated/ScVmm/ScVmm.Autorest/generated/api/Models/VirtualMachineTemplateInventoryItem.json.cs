// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>The Virtual machine template inventory item.</summary>
    public partial class VirtualMachineTemplateInventoryItem
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualMachineTemplateInventoryItem.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualMachineTemplateInventoryItem.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualMachineTemplateInventoryItem FromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json ? new VirtualMachineTemplateInventoryItem(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualMachineTemplateInventoryItem" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualMachineTemplateInventoryItem" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __inventoryItemProperties?.ToJson(container, serializationMode);
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._cpuCount ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNumber((int)this._cpuCount) : null, "cpuCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._memoryMb ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNumber((int)this._memoryMb) : null, "memoryMB" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._oSName.ToString()) : null, "osName" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject into a new instance of <see cref="VirtualMachineTemplateInventoryItem" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualMachineTemplateInventoryItem(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __inventoryItemProperties = new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.InventoryItemProperties(json);
            {_cpuCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNumber>("cpuCount"), out var __jsonCpuCount) ? (int?)__jsonCpuCount : _cpuCount;}
            {_memoryMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNumber>("memoryMB"), out var __jsonMemoryMb) ? (int?)__jsonMemoryMb : _memoryMb;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)_oSType;}
            {_oSName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("osName"), out var __jsonOSName) ? (string)__jsonOSName : (string)_oSName;}
            AfterFromJson(json);
        }
    }
}