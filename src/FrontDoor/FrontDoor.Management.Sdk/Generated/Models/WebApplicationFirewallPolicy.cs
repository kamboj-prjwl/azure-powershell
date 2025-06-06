// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using System.Linq;

    /// <summary>
    /// Defines web application firewall policy.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class WebApplicationFirewallPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the WebApplicationFirewallPolicy class.
        /// </summary>
        public WebApplicationFirewallPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebApplicationFirewallPolicy class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="etag">Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </param>

        /// <param name="sku">The pricing tier of web application firewall policy. Defaults to
        /// Classic_AzureFrontDoor if not specified.
        /// </param>

        /// <param name="policySettings">Describes settings for the policy.
        /// </param>

        /// <param name="customRules">Describes custom rules inside the policy.
        /// </param>

        /// <param name="managedRules">Describes managed rules inside the policy.
        /// </param>

        /// <param name="frontendEndpointLinks">Describes Frontend Endpoints associated with this Web Application Firewall
        /// policy.
        /// </param>

        /// <param name="routingRuleLinks">Describes Routing Rules associated with this Web Application Firewall
        /// policy.
        /// </param>

        /// <param name="securityPolicyLinks">Describes Security Policy associated with this Web Application Firewall
        /// policy.
        /// </param>

        /// <param name="provisioningState">Provisioning state of the policy.
        /// </param>

        /// <param name="resourceState">Resource status of the policy.
        /// Possible values include: &#39;Creating&#39;, &#39;Enabling&#39;, &#39;Enabled&#39;, &#39;Disabling&#39;,
        /// &#39;Disabled&#39;, &#39;Deleting&#39;</param>
        public WebApplicationFirewallPolicy(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), Sku sku = default(Sku), PolicySettings policySettings = default(PolicySettings), CustomRuleList customRules = default(CustomRuleList), ManagedRuleSetList managedRules = default(ManagedRuleSetList), System.Collections.Generic.IList<FrontendEndpointLink> frontendEndpointLinks = default(System.Collections.Generic.IList<FrontendEndpointLink>), System.Collections.Generic.IList<RoutingRuleLink> routingRuleLinks = default(System.Collections.Generic.IList<RoutingRuleLink>), System.Collections.Generic.IList<SecurityPolicyLink> securityPolicyLinks = default(System.Collections.Generic.IList<SecurityPolicyLink>), string provisioningState = default(string), string resourceState = default(string))

        : base(id, name, type, location, tags)
        {
            this.Etag = etag;
            this.Sku = sku;
            this.PolicySettings = policySettings;
            this.CustomRules = customRules;
            this.ManagedRules = managedRules;
            this.FrontendEndpointLinks = frontendEndpointLinks;
            this.RoutingRuleLinks = routingRuleLinks;
            this.SecurityPolicyLinks = securityPolicyLinks;
            this.ProvisioningState = provisioningState;
            this.ResourceState = resourceState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; set; }

        /// <summary>
        /// Gets or sets the pricing tier of web application firewall policy. Defaults
        /// to Classic_AzureFrontDoor if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku {get; set; }

        /// <summary>
        /// Gets or sets describes settings for the policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.policySettings")]
        public PolicySettings PolicySettings {get; set; }

        /// <summary>
        /// Gets or sets describes custom rules inside the policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customRules")]
        public CustomRuleList CustomRules {get; set; }

        /// <summary>
        /// Gets or sets describes managed rules inside the policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.managedRules")]
        public ManagedRuleSetList ManagedRules {get; set; }

        /// <summary>
        /// Gets describes Frontend Endpoints associated with this Web Application
        /// Firewall policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.frontendEndpointLinks")]
        public System.Collections.Generic.IList<FrontendEndpointLink> FrontendEndpointLinks {get; private set; }

        /// <summary>
        /// Gets describes Routing Rules associated with this Web Application Firewall
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routingRuleLinks")]
        public System.Collections.Generic.IList<RoutingRuleLink> RoutingRuleLinks {get; private set; }

        /// <summary>
        /// Gets describes Security Policy associated with this Web Application
        /// Firewall policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.securityPolicyLinks")]
        public System.Collections.Generic.IList<SecurityPolicyLink> SecurityPolicyLinks {get; private set; }

        /// <summary>
        /// Gets provisioning state of the policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets resource status of the policy. Possible values include: &#39;Creating&#39;, &#39;Enabling&#39;, &#39;Enabled&#39;, &#39;Disabling&#39;, &#39;Disabled&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {


            if (this.PolicySettings != null)
            {
                this.PolicySettings.Validate();
            }







        }
    }
}