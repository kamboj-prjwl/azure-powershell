// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.
    /// </summary>
    public partial class NamedValueSecretContract
    {
        /// <summary>
        /// Initializes a new instance of the NamedValueSecretContract class.
        /// </summary>
        public NamedValueSecretContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamedValueSecretContract class.
        /// </summary>

        /// <param name="value">This is secret value of the NamedValue entity.
        /// </param>
        public NamedValueSecretContract(string value = default(string))

        {
            this.Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets this is secret value of the NamedValue entity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value {get; set; }
    }
}