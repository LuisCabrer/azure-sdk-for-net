// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.Commerce.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Commerce;
    using Microsoft.AzureStack.Management.Commerce.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Aggregate usage values for resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UsageAggregate : Resource
    {
        /// <summary>
        /// Initializes a new instance of the UsageAggregate class.
        /// </summary>
        public UsageAggregate()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageAggregate class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="subscriptionId">Subscription id of tenant using
        /// plan.</param>
        /// <param name="usageStartTime">UTC start time for the usage bucket to
        /// which this usage aggregate belongs.</param>
        /// <param name="usageEndTime">UTC end time for the usage bucket to
        /// which this usage aggregate belongs.</param>
        /// <param name="instanceData">Key-value pairs of instance details
        /// represented as a string.</param>
        /// <param name="quantity">The amount of the resource consumption that
        /// occurred in this time frame.</param>
        /// <param name="meterId">Unique ID for the resource that was consumed
        /// (aka ResourceID).</param>
        public UsageAggregate(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string subscriptionId = default(string), System.DateTime? usageStartTime = default(System.DateTime?), System.DateTime? usageEndTime = default(System.DateTime?), string instanceData = default(string), string quantity = default(string), string meterId = default(string))
            : base(id, name, type, location, tags)
        {
            SubscriptionId = subscriptionId;
            UsageStartTime = usageStartTime;
            UsageEndTime = usageEndTime;
            InstanceData = instanceData;
            Quantity = quantity;
            MeterId = meterId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets subscription id of tenant using plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets UTC start time for the usage bucket to which this
        /// usage aggregate belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageStartTime")]
        public System.DateTime? UsageStartTime { get; set; }

        /// <summary>
        /// Gets or sets UTC end time for the usage bucket to which this usage
        /// aggregate belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageEndTime")]
        public System.DateTime? UsageEndTime { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of instance details represented as a
        /// string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceData")]
        public string InstanceData { get; set; }

        /// <summary>
        /// Gets or sets the amount of the resource consumption that occurred
        /// in this time frame.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets unique ID for the resource that was consumed (aka
        /// ResourceID).
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public string MeterId { get; set; }

    }
}
