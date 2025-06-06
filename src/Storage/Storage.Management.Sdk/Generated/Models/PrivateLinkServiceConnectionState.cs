// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// A collection of information about the state of the connection between
    /// service consumer and provider.
    /// </summary>
    public partial class PrivateLinkServiceConnectionState
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionState class.
        /// </summary>
        public PrivateLinkServiceConnectionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnectionState class.
        /// </summary>

        /// <param name="status">Indicates whether the connection has been Approved/Rejected/Removed by the
        /// owner of the service.
        /// Possible values include: &#39;Pending&#39;, &#39;Approved&#39;, &#39;Rejected&#39;</param>

        /// <param name="description">The reason for approval/rejection of the connection.
        /// </param>

        /// <param name="actionRequired">A message indicating if changes on the service provider require any updates
        /// on the consumer.
        /// </param>
        public PrivateLinkServiceConnectionState(string status = default(string), string description = default(string), string actionRequired = default(string))

        {
            this.Status = status;
            this.Description = description;
            this.ActionRequired = actionRequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates whether the connection has been
        /// Approved/Rejected/Removed by the owner of the service. Possible values include: &#39;Pending&#39;, &#39;Approved&#39;, &#39;Rejected&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }

        /// <summary>
        /// Gets or sets the reason for approval/rejection of the connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets a message indicating if changes on the service provider
        /// require any updates on the consumer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionRequired")]
        public string ActionRequired {get; set; }
    }
}