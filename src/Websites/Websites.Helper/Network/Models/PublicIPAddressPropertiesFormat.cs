// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Public IP address properties.
    /// </summary>
    public partial class PublicIPAddressPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddressPropertiesFormat class.
        /// </summary>
        public PublicIPAddressPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddressPropertiesFormat class.
        /// </summary>

        /// <param name="publicIPAllocationMethod">The public IP address allocation method.
        /// Possible values include: &#39;Static&#39;, &#39;Dynamic&#39;</param>

        /// <param name="publicIPAddressVersion">The public IP address version.
        /// Possible values include: &#39;IPv4&#39;, &#39;IPv6&#39;</param>

        /// <param name="ipConfiguration">The IP configuration associated with the public IP address.
        /// </param>

        /// <param name="dnsSettings">The FQDN of the DNS record associated with the public IP address.
        /// </param>

        /// <param name="ddosSettings">The DDoS protection custom policy associated with the public IP address.
        /// </param>

        /// <param name="ipTags">The list of tags associated with the public IP address.
        /// </param>

        /// <param name="ipAddress">The IP address associated with the public IP address resource.
        /// </param>

        /// <param name="publicIPPrefix">The Public IP Prefix this Public IP Address should be allocated from.
        /// </param>

        /// <param name="idleTimeoutInMinutes">The idle timeout of the public IP address.
        /// </param>

        /// <param name="resourceGuid">The resource GUID property of the public IP address resource.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the public IP address resource.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;</param>
        public PublicIPAddressPropertiesFormat(string publicIPAllocationMethod = default(string), string publicIPAddressVersion = default(string), IPConfiguration ipConfiguration = default(IPConfiguration), PublicIPAddressDnsSettings dnsSettings = default(PublicIPAddressDnsSettings), DdosSettings ddosSettings = default(DdosSettings), System.Collections.Generic.IList<IpTag> ipTags = default(System.Collections.Generic.IList<IpTag>), string ipAddress = default(string), SubResource publicIPPrefix = default(SubResource), int? idleTimeoutInMinutes = default(int?), string resourceGuid = default(string), string provisioningState = default(string))

        {
            this.PublicIPAllocationMethod = publicIPAllocationMethod;
            this.PublicIPAddressVersion = publicIPAddressVersion;
            this.IPConfiguration = ipConfiguration;
            this.DnsSettings = dnsSettings;
            this.DdosSettings = ddosSettings;
            this.IPTags = ipTags;
            this.IPAddress = ipAddress;
            this.PublicIPPrefix = publicIPPrefix;
            this.IdleTimeoutInMinutes = idleTimeoutInMinutes;
            this.ResourceGuid = resourceGuid;
            this.ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the public IP address allocation method. Possible values include: &#39;Static&#39;, &#39;Dynamic&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIPAllocationMethod")]
        public string PublicIPAllocationMethod {get; set; }

        /// <summary>
        /// Gets or sets the public IP address version. Possible values include: &#39;IPv4&#39;, &#39;IPv6&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIPAddressVersion")]
        public string PublicIPAddressVersion {get; set; }

        /// <summary>
        /// Gets the IP configuration associated with the public IP address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipConfiguration")]
        public IPConfiguration IPConfiguration {get; private set; }

        /// <summary>
        /// Gets or sets the FQDN of the DNS record associated with the public IP
        /// address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dnsSettings")]
        public PublicIPAddressDnsSettings DnsSettings {get; set; }

        /// <summary>
        /// Gets or sets the DDoS protection custom policy associated with the public
        /// IP address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ddosSettings")]
        public DdosSettings DdosSettings {get; set; }

        /// <summary>
        /// Gets or sets the list of tags associated with the public IP address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipTags")]
        public System.Collections.Generic.IList<IpTag> IPTags {get; set; }

        /// <summary>
        /// Gets or sets the IP address associated with the public IP address resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipAddress")]
        public string IPAddress {get; set; }

        /// <summary>
        /// Gets or sets the Public IP Prefix this Public IP Address should be
        /// allocated from.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIPPrefix")]
        public SubResource PublicIPPrefix {get; set; }

        /// <summary>
        /// Gets or sets the idle timeout of the public IP address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes {get; set; }

        /// <summary>
        /// Gets the resource GUID property of the public IP address resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceGuid")]
        public string ResourceGuid {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the public IP address resource. Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {


            if (this.IPConfiguration != null)
            {
                this.IPConfiguration.Validate();
            }







        }
    }
}