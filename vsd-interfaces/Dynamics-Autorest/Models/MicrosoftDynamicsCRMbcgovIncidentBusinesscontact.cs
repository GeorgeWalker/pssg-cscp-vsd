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
    /// bcgov_incident_businesscontact
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovIncidentBusinesscontact
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovIncidentBusinesscontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovIncidentBusinesscontact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovIncidentBusinesscontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovIncidentBusinesscontact(string bcgovBusinesscontactid = default(string), string bcgovIncidentBusinesscontactid = default(string), string incidentid = default(string), long? versionnumber = default(long?))
        {
            BcgovBusinesscontactid = bcgovBusinesscontactid;
            BcgovIncidentBusinesscontactid = bcgovIncidentBusinesscontactid;
            Incidentid = incidentid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_businesscontactid")]
        public string BcgovBusinesscontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_incident_businesscontactid")]
        public string BcgovIncidentBusinesscontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid")]
        public string Incidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
