// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerInstance;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A container group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ContainerGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ContainerGroup class.
        /// </summary>
        public ContainerGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerGroup class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="containers">The containers in this container
        /// group.</param>
        /// <param name="imageRegistryCredentials">The image registry
        /// credentials by which the container group is created from.</param>
        /// <param name="restartPolicy">- `always` Always restart
        /// . Possible values include: 'always'</param>
        /// <param name="ipAddress">The IP address type.</param>
        /// <param name="osType">The base level OS type required by the
        /// containers in the group. Possible values include: 'Windows',
        /// 'Linux'</param>
        /// <param name="state">The state of the container group. Only valid in
        /// response.</param>
        /// <param name="volumes">The volumes for this container group.</param>
        public ContainerGroup(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), IList<Container> containers = default(IList<Container>), IList<ImageRegistryCredential> imageRegistryCredentials = default(IList<ImageRegistryCredential>), string restartPolicy = default(string), IpAddress ipAddress = default(IpAddress), string osType = default(string), string state = default(string), IList<Volume> volumes = default(IList<Volume>))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            Containers = containers;
            ImageRegistryCredentials = imageRegistryCredentials;
            RestartPolicy = restartPolicy;
            IpAddress = ipAddress;
            OsType = osType;
            State = state;
            Volumes = volumes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the containers in this container group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containers")]
        public IList<Container> Containers { get; set; }

        /// <summary>
        /// Gets or sets the image registry credentials by which the container
        /// group is created from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.imageRegistryCredentials")]
        public IList<ImageRegistryCredential> ImageRegistryCredentials { get; set; }

        /// <summary>
        /// Gets or sets - `always` Always restart
        /// . Possible values include: 'always'
        /// </summary>
        [JsonProperty(PropertyName = "properties.restartPolicy")]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// Gets or sets the IP address type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public IpAddress IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the base level OS type required by the containers in
        /// the group. Possible values include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets the state of the container group. Only valid in response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets the volumes for this container group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumes")]
        public IList<Volume> Volumes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Containers != null)
            {
                foreach (var element in Containers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ImageRegistryCredentials != null)
            {
                foreach (var element1 in ImageRegistryCredentials)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (IpAddress != null)
            {
                IpAddress.Validate();
            }
            if (Volumes != null)
            {
                foreach (var element2 in Volumes)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
