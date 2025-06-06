// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Contains the IP tag associated with the public IP address.
    /// </summary>
    public partial class VirtualMachineIpTag
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineIpTag class.
        /// </summary>
        public VirtualMachineIpTag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineIpTag class.
        /// </summary>

        /// <param name="ipTagType">IP tag type. Example: FirstPartyUsage.
        /// </param>

        /// <param name="tag">IP tag associated with the public IP. Example: SQL, Storage etc.
        /// </param>
        public VirtualMachineIpTag(string ipTagType = default(string), string tag = default(string))

        {
            this.IPTagType = ipTagType;
            this.Tag = tag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets iP tag type. Example: FirstPartyUsage.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipTagType")]
        public string IPTagType {get; set; }

        /// <summary>
        /// Gets or sets iP tag associated with the public IP. Example: SQL, Storage
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tag")]
        public string Tag {get; set; }
    }
}