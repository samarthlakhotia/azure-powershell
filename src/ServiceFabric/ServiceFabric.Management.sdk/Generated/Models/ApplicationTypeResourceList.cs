// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using System.Linq;

    /// <summary>
    /// The list of application type names.
    /// </summary>
    public partial class ApplicationTypeResourceList
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationTypeResourceList class.
        /// </summary>
        public ApplicationTypeResourceList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationTypeResourceList class.
        /// </summary>

        /// <param name="value">
        /// </param>

        /// <param name="nextLink">URL to get the next set of application type list results if there are any.
        /// </param>
        public ApplicationTypeResourceList(System.Collections.Generic.IList<ApplicationTypeResource> value = default(System.Collections.Generic.IList<ApplicationTypeResource>), string nextLink = default(string))

        {
            this.Value = value;
            this.NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<ApplicationTypeResource> Value {get; set; }

        /// <summary>
        /// Gets uRL to get the next set of application type list results if there are
        /// any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink {get; private set; }
    }
}