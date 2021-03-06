// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.InfrastructureInsights;
    using Microsoft.AzureStack.Management.InfrastructureInsights.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This class models an alert resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Alert : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="closedTimestamp">Gets or sets the closed timestamp of
        /// the alert.</param>
        /// <param name="createdTimestamp">Gets or sets the created timestamp
        /// of the alert.</param>
        /// <param name="description">Gets or sets the description of the
        /// alert.</param>
        /// <param name="faultId">Gets or sets the fault id of the
        /// alert.</param>
        /// <param name="alertId">Gets or sets the id of the alert.</param>
        /// <param name="faultTypeId">Gets or sets the fault type id of the
        /// alert.</param>
        /// <param name="lastUpdatedTimestamp">Gets or sets last updated
        /// timestamp of the alert.</param>
        /// <param name="alertProperties">Gets or sets properties of the
        /// alert.</param>
        /// <param name="remediation">Gets or sets the admin friendly
        /// remediation instructions for the alert.</param>
        /// <param name="resourceRegistrationId">Gets or sets the registration
        /// id of the atomic component the alert belongs to.  This is null if
        /// not associated with a resource.</param>
        /// <param name="resourceProviderRegistrationId">Gets or sets the
        /// registration id of the service the alert belongs to.</param>
        /// <param name="severity">Gets or sets the severity of the
        /// alert.</param>
        /// <param name="state">Gets or sets the state of the alert.</param>
        /// <param name="title">Gets or sets the ResourceId for the impacted
        /// item.</param>
        /// <param name="impactedResourceId">Gets or sets the ResourceId for
        /// the impacted item.</param>
        /// <param name="impactedResourceDisplayName">Gets or sets the display
        /// name for the impacted item.</param>
        /// <param name="closedByUserAlias">Gets or sets the user alias who
        /// closed the alert.</param>
        public Alert(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string closedTimestamp = default(string), string createdTimestamp = default(string), IList<IDictionary<string, string>> description = default(IList<IDictionary<string, string>>), string faultId = default(string), string alertId = default(string), string faultTypeId = default(string), string lastUpdatedTimestamp = default(string), IDictionary<string, string> alertProperties = default(IDictionary<string, string>), IList<IDictionary<string, string>> remediation = default(IList<IDictionary<string, string>>), string resourceRegistrationId = default(string), string resourceProviderRegistrationId = default(string), string severity = default(string), string state = default(string), string title = default(string), string impactedResourceId = default(string), string impactedResourceDisplayName = default(string), string closedByUserAlias = default(string))
            : base(id, name, type, location, tags)
        {
            ClosedTimestamp = closedTimestamp;
            CreatedTimestamp = createdTimestamp;
            Description = description;
            FaultId = faultId;
            AlertId = alertId;
            FaultTypeId = faultTypeId;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            AlertProperties = alertProperties;
            Remediation = remediation;
            ResourceRegistrationId = resourceRegistrationId;
            ResourceProviderRegistrationId = resourceProviderRegistrationId;
            Severity = severity;
            State = state;
            Title = title;
            ImpactedResourceId = impactedResourceId;
            ImpactedResourceDisplayName = impactedResourceDisplayName;
            ClosedByUserAlias = closedByUserAlias;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the closed timestamp of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.closedTimestamp")]
        public string ClosedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the created timestamp of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTimestamp")]
        public string CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the description of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public IList<IDictionary<string, string>> Description { get; set; }

        /// <summary>
        /// Gets or sets the fault id of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.faultId")]
        public string FaultId { get; set; }

        /// <summary>
        /// Gets or sets the id of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertId")]
        public string AlertId { get; set; }

        /// <summary>
        /// Gets or sets the fault type id of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.faultTypeId")]
        public string FaultTypeId { get; set; }

        /// <summary>
        /// Gets or sets last updated timestamp of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTimestamp")]
        public string LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets properties of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertProperties")]
        public IDictionary<string, string> AlertProperties { get; set; }

        /// <summary>
        /// Gets or sets the admin friendly remediation instructions for the
        /// alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remediation")]
        public IList<IDictionary<string, string>> Remediation { get; set; }

        /// <summary>
        /// Gets or sets the registration id of the atomic component the alert
        /// belongs to.  This is null if not associated with a resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceRegistrationId")]
        public string ResourceRegistrationId { get; set; }

        /// <summary>
        /// Gets or sets the registration id of the service the alert belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceProviderRegistrationId")]
        public string ResourceProviderRegistrationId { get; set; }

        /// <summary>
        /// Gets or sets the severity of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the state of the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the ResourceId for the impacted item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ResourceId for the impacted item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.impactedResourceId")]
        public string ImpactedResourceId { get; set; }

        /// <summary>
        /// Gets or sets the display name for the impacted item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.impactedResourceDisplayName")]
        public string ImpactedResourceDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the user alias who closed the alert.
        /// </summary>
        [JsonProperty(PropertyName = "properties.closedByUserAlias")]
        public string ClosedByUserAlias { get; set; }

    }
}
