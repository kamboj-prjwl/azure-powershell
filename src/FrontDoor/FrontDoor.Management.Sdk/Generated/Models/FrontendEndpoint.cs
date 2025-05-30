// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using System.Linq;

    /// <summary>
    /// A frontend endpoint used for routing.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class FrontendEndpoint : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the FrontendEndpoint class.
        /// </summary>
        public FrontendEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FrontendEndpoint class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="hostName">The host name of the frontendEndpoint. Must be a domain name.
        /// </param>

        /// <param name="sessionAffinityEnabledState">Whether to allow session affinity on this host. Valid options are &#39;Enabled&#39;
        /// or &#39;Disabled&#39;
        /// Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;</param>

        /// <param name="sessionAffinityTtlSeconds">UNUSED. This field will be ignored. The TTL to use in seconds for session
        /// affinity, if applicable.
        /// </param>

        /// <param name="webApplicationFirewallPolicyLink">Defines the Web Application Firewall policy for each host (if applicable)
        /// </param>

        /// <param name="resourceState">Resource status.
        /// Possible values include: &#39;Creating&#39;, &#39;Enabling&#39;, &#39;Enabled&#39;, &#39;Disabling&#39;,
        /// &#39;Disabled&#39;, &#39;Deleting&#39;, &#39;Migrating&#39;, &#39;Migrated&#39;</param>

        /// <param name="customHttpsProvisioningState">Provisioning status of Custom Https of the frontendEndpoint.
        /// Possible values include: &#39;Enabling&#39;, &#39;Enabled&#39;, &#39;Disabling&#39;, &#39;Disabled&#39;,
        /// &#39;Failed&#39;</param>

        /// <param name="customHttpsProvisioningSubstate">Provisioning substate shows the progress of custom HTTPS enabling/disabling
        /// process step by step.
        /// Possible values include: &#39;SubmittingDomainControlValidationRequest&#39;,
        /// &#39;PendingDomainControlValidationREquestApproval&#39;,
        /// &#39;DomainControlValidationRequestApproved&#39;,
        /// &#39;DomainControlValidationRequestRejected&#39;,
        /// &#39;DomainControlValidationRequestTimedOut&#39;, &#39;IssuingCertificate&#39;,
        /// &#39;DeployingCertificate&#39;, &#39;CertificateDeployed&#39;, &#39;DeletingCertificate&#39;,
        /// &#39;CertificateDeleted&#39;</param>

        /// <param name="customHttpsConfiguration">The configuration specifying how to enable HTTPS
        /// </param>
        public FrontendEndpoint(string id = default(string), string name = default(string), string type = default(string), string hostName = default(string), string sessionAffinityEnabledState = default(string), int? sessionAffinityTtlSeconds = default(int?), FrontendEndpointUpdateParametersWebApplicationFirewallPolicyLink webApplicationFirewallPolicyLink = default(FrontendEndpointUpdateParametersWebApplicationFirewallPolicyLink), string resourceState = default(string), string customHttpsProvisioningState = default(string), string customHttpsProvisioningSubstate = default(string), CustomHttpsConfiguration customHttpsConfiguration = default(CustomHttpsConfiguration))

        : base(id)
        {
            this.Name = name;
            this.Type = type;
            this.HostName = hostName;
            this.SessionAffinityEnabledState = sessionAffinityEnabledState;
            this.SessionAffinityTtlSeconds = sessionAffinityTtlSeconds;
            this.WebApplicationFirewallPolicyLink = webApplicationFirewallPolicyLink;
            this.ResourceState = resourceState;
            this.CustomHttpsProvisioningState = customHttpsProvisioningState;
            this.CustomHttpsProvisioningSubstate = customHttpsProvisioningSubstate;
            this.CustomHttpsConfiguration = customHttpsConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets or sets the host name of the frontendEndpoint. Must be a domain name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName {get; set; }

        /// <summary>
        /// Gets or sets whether to allow session affinity on this host. Valid options
        /// are &#39;Enabled&#39; or &#39;Disabled&#39; Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sessionAffinityEnabledState")]
        public string SessionAffinityEnabledState {get; set; }

        /// <summary>
        /// Gets or sets uNUSED. This field will be ignored. The TTL to use in seconds
        /// for session affinity, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sessionAffinityTtlSeconds")]
        public int? SessionAffinityTtlSeconds {get; set; }

        /// <summary>
        /// Gets or sets defines the Web Application Firewall policy for each host (if
        /// applicable)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.webApplicationFirewallPolicyLink")]
        public FrontendEndpointUpdateParametersWebApplicationFirewallPolicyLink WebApplicationFirewallPolicyLink {get; set; }

        /// <summary>
        /// Gets resource status. Possible values include: &#39;Creating&#39;, &#39;Enabling&#39;, &#39;Enabled&#39;, &#39;Disabling&#39;, &#39;Disabled&#39;, &#39;Deleting&#39;, &#39;Migrating&#39;, &#39;Migrated&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState {get; private set; }

        /// <summary>
        /// Gets provisioning status of Custom Https of the frontendEndpoint. Possible values include: &#39;Enabling&#39;, &#39;Enabled&#39;, &#39;Disabling&#39;, &#39;Disabled&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customHttpsProvisioningState")]
        public string CustomHttpsProvisioningState {get; private set; }

        /// <summary>
        /// Gets provisioning substate shows the progress of custom HTTPS
        /// enabling/disabling process step by step. Possible values include: &#39;SubmittingDomainControlValidationRequest&#39;, &#39;PendingDomainControlValidationREquestApproval&#39;, &#39;DomainControlValidationRequestApproved&#39;, &#39;DomainControlValidationRequestRejected&#39;, &#39;DomainControlValidationRequestTimedOut&#39;, &#39;IssuingCertificate&#39;, &#39;DeployingCertificate&#39;, &#39;CertificateDeployed&#39;, &#39;DeletingCertificate&#39;, &#39;CertificateDeleted&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customHttpsProvisioningSubstate")]
        public string CustomHttpsProvisioningSubstate {get; private set; }

        /// <summary>
        /// Gets the configuration specifying how to enable HTTPS
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customHttpsConfiguration")]
        public CustomHttpsConfiguration CustomHttpsConfiguration {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {








            if (this.CustomHttpsConfiguration != null)
            {
                this.CustomHttpsConfiguration.Validate();
            }
        }
    }
}