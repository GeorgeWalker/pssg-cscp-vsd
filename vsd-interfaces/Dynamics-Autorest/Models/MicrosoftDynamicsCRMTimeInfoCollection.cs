// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// TimeInfoCollection
    /// </summary>
    public partial class MicrosoftDynamicsCRMTimeInfoCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMTimeInfoCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMTimeInfoCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMTimeInfoCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMTimeInfoCollection(IList<MicrosoftDynamicsCRMTimeInfo> items = default(IList<MicrosoftDynamicsCRMTimeInfo>))
        {
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Items")]
        public IList<MicrosoftDynamicsCRMTimeInfo> Items { get; set; }

    }
}
