// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// Storage SKU and its properties
    /// </summary>
    public partial class SkuInformation
    {
        /// <summary>
        /// Initializes a new instance of the SkuInformation class.
        /// </summary>
        public SkuInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuInformation class.
        /// </summary>

        /// <param name="name">The SKU name. Required for account creation; optional for update. Note that
        /// in older versions, SKU name was called accountType.
        /// Possible values include: &#39;Standard_LRS&#39;, &#39;Standard_GRS&#39;, &#39;Standard_RAGRS&#39;,
        /// &#39;Standard_ZRS&#39;, &#39;Premium_LRS&#39;, &#39;Premium_ZRS&#39;, &#39;Standard_GZRS&#39;,
        /// &#39;Standard_RAGZRS&#39;, &#39;StandardV2_LRS&#39;, &#39;StandardV2_GRS&#39;, &#39;StandardV2_ZRS&#39;,
        /// &#39;StandardV2_GZRS&#39;, &#39;PremiumV2_LRS&#39;, &#39;PremiumV2_ZRS&#39;</param>

        /// <param name="tier">The SKU tier. This is based on the SKU name.
        /// Possible values include: &#39;Standard&#39;, &#39;Premium&#39;</param>

        /// <param name="resourceType">The type of the resource, usually it is &#39;storageAccounts&#39;.
        /// </param>

        /// <param name="kind">Indicates the type of storage account.
        /// Possible values include: &#39;Storage&#39;, &#39;StorageV2&#39;, &#39;BlobStorage&#39;,
        /// &#39;FileStorage&#39;, &#39;BlockBlobStorage&#39;</param>

        /// <param name="locations">The set of locations that the SKU is available. This will be supported and
        /// registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
        /// </param>

        /// <param name="capabilities">The capability information in the specified SKU, including file encryption,
        /// network ACLs, change notification, etc.
        /// </param>

        /// <param name="restrictions">The restrictions because of which SKU cannot be used. This is empty if
        /// there are no restrictions.
        /// </param>
        public SkuInformation(string name, SkuTier? tier = default(SkuTier?), string resourceType = default(string), string kind = default(string), System.Collections.Generic.IList<string> locations = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<SKUCapability> capabilities = default(System.Collections.Generic.IList<SKUCapability>), System.Collections.Generic.IList<Restriction> restrictions = default(System.Collections.Generic.IList<Restriction>))

        {
            this.Name = name;
            this.Tier = tier;
            this.ResourceType = resourceType;
            this.Kind = kind;
            this.Locations = locations;
            this.Capabilities = capabilities;
            this.Restrictions = restrictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the SKU name. Required for account creation; optional for
        /// update. Note that in older versions, SKU name was called accountType. Possible values include: &#39;Standard_LRS&#39;, &#39;Standard_GRS&#39;, &#39;Standard_RAGRS&#39;, &#39;Standard_ZRS&#39;, &#39;Premium_LRS&#39;, &#39;Premium_ZRS&#39;, &#39;Standard_GZRS&#39;, &#39;Standard_RAGZRS&#39;, &#39;StandardV2_LRS&#39;, &#39;StandardV2_GRS&#39;, &#39;StandardV2_ZRS&#39;, &#39;StandardV2_GZRS&#39;, &#39;PremiumV2_LRS&#39;, &#39;PremiumV2_ZRS&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets the SKU tier. This is based on the SKU name. Possible values include: &#39;Standard&#39;, &#39;Premium&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier {get; private set; }

        /// <summary>
        /// Gets the type of the resource, usually it is &#39;storageAccounts&#39;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceType")]
        public string ResourceType {get; private set; }

        /// <summary>
        /// Gets indicates the type of storage account. Possible values include: &#39;Storage&#39;, &#39;StorageV2&#39;, &#39;BlobStorage&#39;, &#39;FileStorage&#39;, &#39;BlockBlobStorage&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind {get; private set; }

        /// <summary>
        /// Gets the set of locations that the SKU is available. This will be supported
        /// and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia,
        /// etc.).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "locations")]
        public System.Collections.Generic.IList<string> Locations {get; private set; }

        /// <summary>
        /// Gets the capability information in the specified SKU, including file
        /// encryption, network ACLs, change notification, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capabilities")]
        public System.Collections.Generic.IList<SKUCapability> Capabilities {get; private set; }

        /// <summary>
        /// Gets or sets the restrictions because of which SKU cannot be used. This is
        /// empty if there are no restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "restrictions")]
        public System.Collections.Generic.IList<Restriction> Restrictions {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }







        }
    }
}