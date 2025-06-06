// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Private Link Configuration on an application gateway.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayPrivateLinkConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPrivateLinkConfiguration class.
        /// </summary>
        public ApplicationGatewayPrivateLinkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPrivateLinkConfiguration class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Name of the private link configuration that is unique within an Application
        /// Gateway.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="type">Type of the resource.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the application gateway private link
        /// configuration.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="ipConfigurations">An array of application gateway private link ip configurations.
        /// </param>
        public ApplicationGatewayPrivateLinkConfiguration(string id = default(string), string name = default(string), string etag = default(string), string type = default(string), string provisioningState = default(string), System.Collections.Generic.IList<ApplicationGatewayPrivateLinkIpConfiguration> ipConfigurations = default(System.Collections.Generic.IList<ApplicationGatewayPrivateLinkIpConfiguration>))

        : base(id)
        {
            this.Name = name;
            this.Etag = etag;
            this.Type = type;
            this.ProvisioningState = provisioningState;
            this.IPConfigurations = ipConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the private link configuration that is unique within
        /// an Application Gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the application gateway private link
        /// configuration. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets an array of application gateway private link ip
        /// configurations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ipConfigurations")]
        public System.Collections.Generic.IList<ApplicationGatewayPrivateLinkIpConfiguration> IPConfigurations {get; set; }
    }
}