// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using System.Linq;

    /// <summary>
    /// Single Namespace item in List or Get Operation
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class EHNamespace : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the EHNamespace class.
        /// </summary>
        public EHNamespace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EHNamespace class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="sku">Properties of sku resource
        /// </param>

        /// <param name="identity">Properties of BYOK Identity description
        /// </param>

        /// <param name="systemData">The system meta data relating to this resource.
        /// </param>

        /// <param name="encryption">Properties of BYOK Encryption description
        /// </param>

        /// <param name="minimumTlsVersion">The minimum TLS version for the cluster to support, e.g. &#39;1.2&#39;
        /// Possible values include: &#39;1.0&#39;, &#39;1.1&#39;, &#39;1.2&#39;</param>

        /// <param name="provisioningState">Provisioning state of the Namespace.
        /// </param>

        /// <param name="status">Status of the Namespace.
        /// </param>

        /// <param name="createdAt">The time the Namespace was created.
        /// </param>

        /// <param name="updatedAt">The time the Namespace was updated.
        /// </param>

        /// <param name="serviceBusEndpoint">Endpoint you can use to perform Service Bus operations.
        /// </param>

        /// <param name="clusterArmId">Cluster ARM ID of the Namespace.
        /// </param>

        /// <param name="metricId">Identifier for Azure Insights metrics.
        /// </param>

        /// <param name="isAutoInflateEnabled">Value that indicates whether AutoInflate is enabled for eventhub namespace.
        /// </param>

        /// <param name="publicNetworkAccess">This determines if traffic is allowed over public network. By default it is
        /// enabled.
        /// Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;, &#39;SecuredByPerimeter&#39;</param>

        /// <param name="maximumThroughputUnits">Upper limit of throughput units when AutoInflate is enabled, value should
        /// be within 0 to 20 throughput units. ( &#39;0&#39; if AutoInflateEnabled = true)
        /// </param>

        /// <param name="kafkaEnabled">Value that indicates whether Kafka is enabled for eventhub namespace.
        /// </param>

        /// <param name="zoneRedundant">Enabling this property creates a Standard Event Hubs Namespace in regions
        /// supported availability zones.
        /// </param>

        /// <param name="privateEndpointConnections">List of private endpoint connections.
        /// </param>

        /// <param name="disableLocalAuth">This property disables SAS authentication for the Event Hubs namespace.
        /// </param>

        /// <param name="alternateName">Alternate name specified when alias and namespace names are same.
        /// </param>
        public EHNamespace(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Sku sku = default(Sku), Identity identity = default(Identity), SystemData systemData = default(SystemData), Encryption encryption = default(Encryption), string minimumTlsVersion = default(string), string provisioningState = default(string), string status = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string serviceBusEndpoint = default(string), string clusterArmId = default(string), string metricId = default(string), bool? isAutoInflateEnabled = default(bool?), string publicNetworkAccess = default(string), int? maximumThroughputUnits = default(int?), bool? kafkaEnabled = default(bool?), bool? zoneRedundant = default(bool?), System.Collections.Generic.IList<PrivateEndpointConnection> privateEndpointConnections = default(System.Collections.Generic.IList<PrivateEndpointConnection>), bool? disableLocalAuth = default(bool?), string alternateName = default(string))

        : base(id, name, type, location, tags)
        {
            this.Sku = sku;
            this.Identity = identity;
            this.SystemData = systemData;
            this.Encryption = encryption;
            this.MinimumTlsVersion = minimumTlsVersion;
            this.ProvisioningState = provisioningState;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ServiceBusEndpoint = serviceBusEndpoint;
            this.ClusterArmId = clusterArmId;
            this.MetricId = metricId;
            this.IsAutoInflateEnabled = isAutoInflateEnabled;
            this.PublicNetworkAccess = publicNetworkAccess;
            this.MaximumThroughputUnits = maximumThroughputUnits;
            this.KafkaEnabled = kafkaEnabled;
            this.ZoneRedundant = zoneRedundant;
            this.PrivateEndpointConnections = privateEndpointConnections;
            this.DisableLocalAuth = disableLocalAuth;
            this.AlternateName = alternateName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets properties of sku resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku {get; set; }

        /// <summary>
        /// Gets or sets properties of BYOK Identity description
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public Identity Identity {get; set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData {get; private set; }

        /// <summary>
        /// Gets or sets properties of BYOK Encryption description
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption {get; set; }

        /// <summary>
        /// Gets or sets the minimum TLS version for the cluster to support, e.g. &#39;1.2&#39; Possible values include: &#39;1.0&#39;, &#39;1.1&#39;, &#39;1.2&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.minimumTlsVersion")]
        public string MinimumTlsVersion {get; set; }

        /// <summary>
        /// Gets provisioning state of the Namespace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets status of the Namespace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.status")]
        public string Status {get; private set; }

        /// <summary>
        /// Gets the time the Namespace was created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt {get; private set; }

        /// <summary>
        /// Gets the time the Namespace was updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt {get; private set; }

        /// <summary>
        /// Gets endpoint you can use to perform Service Bus operations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceBusEndpoint")]
        public string ServiceBusEndpoint {get; private set; }

        /// <summary>
        /// Gets or sets cluster ARM ID of the Namespace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.clusterArmId")]
        public string ClusterArmId {get; set; }

        /// <summary>
        /// Gets identifier for Azure Insights metrics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId {get; private set; }

        /// <summary>
        /// Gets or sets value that indicates whether AutoInflate is enabled for
        /// eventhub namespace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isAutoInflateEnabled")]
        public bool? IsAutoInflateEnabled {get; set; }

        /// <summary>
        /// Gets or sets this determines if traffic is allowed over public network. By
        /// default it is enabled. Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;, &#39;SecuredByPerimeter&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess {get; set; }

        /// <summary>
        /// Gets or sets upper limit of throughput units when AutoInflate is enabled,
        /// value should be within 0 to 20 throughput units. ( &#39;0&#39; if
        /// AutoInflateEnabled = true)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.maximumThroughputUnits")]
        public int? MaximumThroughputUnits {get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether Kafka is enabled for eventhub
        /// namespace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.kafkaEnabled")]
        public bool? KafkaEnabled {get; set; }

        /// <summary>
        /// Gets or sets enabling this property creates a Standard Event Hubs Namespace
        /// in regions supported availability zones.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.zoneRedundant")]
        public bool? ZoneRedundant {get; set; }

        /// <summary>
        /// Gets or sets list of private endpoint connections.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public System.Collections.Generic.IList<PrivateEndpointConnection> PrivateEndpointConnections {get; set; }

        /// <summary>
        /// Gets or sets this property disables SAS authentication for the Event Hubs
        /// namespace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.disableLocalAuth")]
        public bool? DisableLocalAuth {get; set; }

        /// <summary>
        /// Gets or sets alternate name specified when alias and namespace names are
        /// same.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.alternateName")]
        public string AlternateName {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }












        }
    }
}