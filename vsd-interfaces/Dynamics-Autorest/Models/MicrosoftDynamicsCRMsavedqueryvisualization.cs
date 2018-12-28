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
    /// savedqueryvisualization
    /// </summary>
    public partial class MicrosoftDynamicsCRMsavedqueryvisualization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsavedqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedqueryvisualization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsavedqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedqueryvisualization(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string primaryentitytypecode = default(string), string description = default(string), string _webresourceidValue = default(string), long? versionnumber = default(long?), string presentationdescription = default(string), string savedqueryvisualizationidunique = default(string), string solutionid = default(string), bool? isdefault = default(bool?), string introducedversion = default(string), string _modifiedonbehalfbyValue = default(string), int? componentstate = default(int?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), int? type = default(int?), int? charttype = default(int?), string _organizationidValue = default(string), string name = default(string), string datadescription = default(string), bool? ismanaged = default(bool?), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), MicrosoftDynamicsCRMBooleanManagedProperty canbedeleted = default(MicrosoftDynamicsCRMBooleanManagedProperty), string savedqueryvisualizationid = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMsyncerror> savedQueryVisualizationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMwebresource webresourceid = default(MicrosoftDynamicsCRMwebresource), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Createdon = createdon;
            Primaryentitytypecode = primaryentitytypecode;
            Description = description;
            this._webresourceidValue = _webresourceidValue;
            Versionnumber = versionnumber;
            Presentationdescription = presentationdescription;
            Savedqueryvisualizationidunique = savedqueryvisualizationidunique;
            Solutionid = solutionid;
            Isdefault = isdefault;
            Introducedversion = introducedversion;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Componentstate = componentstate;
            Iscustomizable = iscustomizable;
            Type = type;
            Charttype = charttype;
            this._organizationidValue = _organizationidValue;
            Name = name;
            Datadescription = datadescription;
            Ismanaged = ismanaged;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Canbedeleted = canbedeleted;
            Savedqueryvisualizationid = savedqueryvisualizationid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overwritetime = overwritetime;
            SavedQueryVisualizationSyncErrors = savedQueryVisualizationSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            Organizationid = organizationid;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Webresourceid = webresourceid;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_webresourceid_value")]
        public string _webresourceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "presentationdescription")]
        public string Presentationdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryvisualizationidunique")]
        public string Savedqueryvisualizationidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "charttype")]
        public int? Charttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datadescription")]
        public string Datadescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryvisualizationid")]
        public string Savedqueryvisualizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SavedQueryVisualization_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SavedQueryVisualizationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public MicrosoftDynamicsCRMwebresource Webresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
