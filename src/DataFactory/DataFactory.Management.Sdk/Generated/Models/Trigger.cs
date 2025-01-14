// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure data factory nested object which contains information about
    /// creating pipeline run
    /// </summary>
    [Newtonsoft.Json.JsonObject("Trigger")]
    public partial class Trigger
    {
        /// <summary>
        /// Initializes a new instance of the Trigger class.
        /// </summary>
        public Trigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Trigger class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Trigger description.</param>
        /// <param name="runtimeState">Indicates if trigger is running or not.
        /// Updated when Start/Stop APIs are called on the Trigger. Possible
        /// values include: 'Started', 'Stopped', 'Disabled'</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the trigger.</param>
        public Trigger(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), string runtimeState = default(string), IList<object> annotations = default(IList<object>))
        {
            AdditionalProperties = additionalProperties;
            Description = description;
            RuntimeState = runtimeState;
            Annotations = annotations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets trigger description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets indicates if trigger is running or not. Updated when
        /// Start/Stop APIs are called on the Trigger. Possible values include:
        /// 'Started', 'Stopped', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "runtimeState")]
        public string RuntimeState { get; private set; }

        /// <summary>
        /// Gets or sets list of tags that can be used for describing the
        /// trigger.
        /// </summary>
        [JsonProperty(PropertyName = "annotations")]
        public IList<object> Annotations { get; set; }

    }
}
