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
    /// entitlementcontacts
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementcontacts
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementcontacts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementcontacts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementcontacts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementcontacts(string entitlementcontactid = default(string), string entitlementid = default(string), long? versionnumber = default(long?), string contactid = default(string))
        {
            Entitlementcontactid = entitlementcontactid;
            Entitlementid = entitlementid;
            Versionnumber = versionnumber;
            Contactid = contactid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementcontactid")]
        public string Entitlementcontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementid")]
        public string Entitlementid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

    }
}
