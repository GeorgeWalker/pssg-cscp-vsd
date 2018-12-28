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
    /// postfollow
    /// </summary>
    public partial class MicrosoftDynamicsCRMpostfollow
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostfollow
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostfollow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostfollow
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostfollow(string _owningteamValue = default(string), string postfollowid = default(string), string _owninguserValue = default(string), string _regardingobjectidValue = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _owneridValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), int? yammerpoststate = default(int?), long? versionnumber = default(long?), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMtask regardingobjectidTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMappointment regardingobjectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMphonecall regardingobjectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMrecurringappointmentmaster regardingobjectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMsystemuser regardingobjectidSystemuser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> postFollowAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMqueue regardingobjectidQueue = default(MicrosoftDynamicsCRMqueue), IList<MicrosoftDynamicsCRMsyncerror> postFollowSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMcompetitor regardingobjectidCompetitor = default(MicrosoftDynamicsCRMcompetitor))
        {
            this._owningteamValue = _owningteamValue;
            Postfollowid = postfollowid;
            this._owninguserValue = _owninguserValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owneridValue = _owneridValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Yammerpoststate = yammerpoststate;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            RegardingobjectidTask = regardingobjectidTask;
            RegardingobjectidAppointment = regardingobjectidAppointment;
            RegardingobjectidPhonecall = regardingobjectidPhonecall;
            RegardingobjectidIncident = regardingobjectidIncident;
            RegardingobjectidRecurringappointmentmaster = regardingobjectidRecurringappointmentmaster;
            Createdby = createdby;
            RegardingobjectidAccount = regardingobjectidAccount;
            RegardingobjectidContact = regardingobjectidContact;
            RegardingobjectidLead = regardingobjectidLead;
            RegardingobjectidOpportunity = regardingobjectidOpportunity;
            RegardingobjectidSystemuser = regardingobjectidSystemuser;
            PostFollowAsyncOperations = postFollowAsyncOperations;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Createdonbehalfby = createdonbehalfby;
            RegardingobjectidQueue = regardingobjectidQueue;
            PostFollowSyncErrors = postFollowSyncErrors;
            RegardingobjectidKnowledgearticle = regardingobjectidKnowledgearticle;
            RegardingobjectidCompetitor = regardingobjectidCompetitor;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postfollowid")]
        public string Postfollowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "yammerpoststate")]
        public int? Yammerpoststate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_task")]
        public MicrosoftDynamicsCRMtask RegardingobjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_appointment")]
        public MicrosoftDynamicsCRMappointment RegardingobjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall RegardingobjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster RegardingobjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser RegardingobjectidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostFollow_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PostFollowAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_queue")]
        public MicrosoftDynamicsCRMqueue RegardingobjectidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostFollow_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PostFollowSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_competitor")]
        public MicrosoftDynamicsCRMcompetitor RegardingobjectidCompetitor { get; set; }

    }
}
