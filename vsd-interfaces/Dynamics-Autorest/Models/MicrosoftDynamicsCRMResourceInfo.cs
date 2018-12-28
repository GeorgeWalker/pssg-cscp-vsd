// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ResourceInfo
    /// </summary>
    public partial class MicrosoftDynamicsCRMResourceInfo
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMResourceInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMResourceInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMResourceInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMResourceInfo(string id = default(string), string displayName = default(string), string entityName = default(string))
        {
            Id = id;
            DisplayName = displayName;
            EntityName = entityName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityName")]
        public string EntityName { get; set; }

    }
}
