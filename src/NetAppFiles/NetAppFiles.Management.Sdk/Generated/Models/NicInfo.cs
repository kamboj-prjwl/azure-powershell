// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// NIC information and list of volumes for which the NIC has the primary mount
    /// ip address.
    /// </summary>
    /// <remarks>
    /// NIC information and list of volumes for which the NIC has the primary mount
    /// ip address.
    /// </remarks>
    public partial class NicInfo
    {
        /// <summary>
        /// Initializes a new instance of the NicInfo class.
        /// </summary>
        public NicInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NicInfo class.
        /// </summary>

        /// <param name="ipAddress">ipAddress
        /// </param>

        /// <param name="volumeResourceIds">Volume resource Ids
        /// </param>
        public NicInfo(string ipAddress = default(string), System.Collections.Generic.IList<string> volumeResourceIds = default(System.Collections.Generic.IList<string>))

        {
            this.IPAddress = ipAddress;
            this.VolumeResourceIds = volumeResourceIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets ipAddress
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipAddress")]
        public string IPAddress {get; private set; }

        /// <summary>
        /// Gets or sets volume resource Ids
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "volumeResourceIds")]
        public System.Collections.Generic.IList<string> VolumeResourceIds {get; set; }
    }
}