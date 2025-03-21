// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Contains the information necessary to perform a resource move (rename).
    /// </summary>
    public partial class ResourceMoveDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMoveDefinition class.
        /// </summary>
        public ResourceMoveDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceMoveDefinition class.
        /// </summary>

        /// <param name="id">The target ID for the resource
        /// </param>
        public ResourceMoveDefinition(string id)

        {
            this.Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the target ID for the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }

        }
    }
}