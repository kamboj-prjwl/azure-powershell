// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Managed integration runtime managed virtual network reference.
    /// </summary>
    public partial class ManagedIntegrationRuntimeManagedVirtualNetworkReference
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIntegrationRuntimeManagedVirtualNetworkReference class.
        /// </summary>
        public ManagedIntegrationRuntimeManagedVirtualNetworkReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIntegrationRuntimeManagedVirtualNetworkReference class.
        /// </summary>

        /// <param name="referenceName">The reference name of the managed virtual network.
        /// </param>

        /// <param name="type">The type of the managed virtual network.
        /// </param>

        /// <param name="id">The id of the managed virtual network.
        /// </param>
        public ManagedIntegrationRuntimeManagedVirtualNetworkReference(string referenceName = default(string), string type = default(string), string id = default(string))

        {
            this.ReferenceName = referenceName;
            this.Type = type;
            this.Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the reference name of the managed virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "referenceName")]
        public string ReferenceName {get; set; }

        /// <summary>
        /// Gets or sets the type of the managed virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets the id of the managed virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }
    }
}