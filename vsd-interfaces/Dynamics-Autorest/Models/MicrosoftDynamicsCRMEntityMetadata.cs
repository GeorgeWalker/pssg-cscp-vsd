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
    /// EntityMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMEntityMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEntityMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMEntityMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEntityMetadata class.
        /// </summary>
        /// <param name="ownershipType">Possible values include: 'None',
        /// 'UserOwned', 'TeamOwned', 'BusinessOwned', 'OrganizationOwned',
        /// 'BusinessParented'</param>
        public MicrosoftDynamicsCRMEntityMetadata(int? activityTypeMask = default(int?), bool? autoRouteToOwnerQueue = default(bool?), bool? canTriggerWorkflow = default(bool?), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayCollectionName = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), bool? entityHelpUrlEnabled = default(bool?), string entityHelpUrl = default(string), bool? isDocumentManagementEnabled = default(bool?), bool? isOneNoteIntegrationEnabled = default(bool?), bool? isInteractionCentricEnabled = default(bool?), bool? isKnowledgeManagementEnabled = default(bool?), bool? isSLAEnabled = default(bool?), bool? isBPFEntity = default(bool?), bool? isDocumentRecommendationsEnabled = default(bool?), bool? autoCreateAccessTeams = default(bool?), bool? isActivity = default(bool?), bool? isActivityParty = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isAuditEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isAvailableOffline = default(bool?), bool? isChildEntity = default(bool?), bool? isAIRUpdated = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isValidForQueue = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isConnectionsEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), string iconLargeName = default(string), string iconMediumName = default(string), string iconSmallName = default(string), bool? isCustomEntity = default(bool?), bool? isBusinessProcessEnabled = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isRenameable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isMappable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isDuplicateDetectionEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canCreateAttributes = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canCreateForms = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canCreateViews = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canCreateCharts = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canBeRelatedEntityInRelationship = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canBePrimaryEntityInRelationship = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canBeInManyToMany = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canEnableSyncToExternalSearchIndex = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? syncToExternalSearchIndex = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty canModifyAdditionalSettings = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canChangeHierarchicalRelationship = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isOptimisticConcurrencyEnabled = default(bool?), bool? changeTrackingEnabled = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty canChangeTrackingBeEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isImportable = default(bool?), bool? isIntersect = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isMailMergeEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isManaged = default(bool?), bool? isEnabledForCharts = default(bool?), bool? isEnabledForTrace = default(bool?), bool? isValidForAdvancedFind = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isVisibleInMobile = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isVisibleInMobileClient = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isReadOnlyInMobileClient = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isOfflineInMobileClient = default(MicrosoftDynamicsCRMBooleanManagedProperty), int? daysSinceRecordLastModified = default(int?), string mobileOfflineFilters = default(string), bool? isReadingPaneEnabled = default(bool?), bool? isQuickCreateEnabled = default(bool?), string logicalName = default(string), int? objectTypeCode = default(int?), string ownershipType = default(string), string primaryNameAttribute = default(string), string primaryImageAttribute = default(string), string primaryIdAttribute = default(string), IList<MicrosoftDynamicsCRMSecurityPrivilegeMetadata> privileges = default(IList<MicrosoftDynamicsCRMSecurityPrivilegeMetadata>), string recurrenceBaseEntityLogicalName = default(string), string reportViewName = default(string), string schemaName = default(string), string introducedVersion = default(string), bool? isStateModelAware = default(bool?), bool? enforceStateTransitions = default(bool?), string entityColor = default(string), string logicalCollectionName = default(string), string collectionSchemaName = default(string), string entitySetName = default(string), bool? isEnabledForExternalChannels = default(bool?), bool? isPrivate = default(bool?), bool? usesBusinessDataLabelTable = default(bool?), bool? isLogicalEntity = default(bool?), bool? hasActivities = default(bool?), bool? hasNotes = default(bool?), bool? hasFeedback = default(bool?), IList<MicrosoftDynamicsCRMAttributeMetadata> attributes = default(IList<MicrosoftDynamicsCRMAttributeMetadata>), IList<MicrosoftDynamicsCRMManyToManyRelationshipMetadata> manyToManyRelationships = default(IList<MicrosoftDynamicsCRMManyToManyRelationshipMetadata>), IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> manyToOneRelationships = default(IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata>), IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> oneToManyRelationships = default(IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata>), IList<MicrosoftDynamicsCRMEntityKeyMetadata> keys = default(IList<MicrosoftDynamicsCRMEntityKeyMetadata>))
        {
            ActivityTypeMask = activityTypeMask;
            AutoRouteToOwnerQueue = autoRouteToOwnerQueue;
            CanTriggerWorkflow = canTriggerWorkflow;
            Description = description;
            DisplayCollectionName = displayCollectionName;
            DisplayName = displayName;
            EntityHelpUrlEnabled = entityHelpUrlEnabled;
            EntityHelpUrl = entityHelpUrl;
            IsDocumentManagementEnabled = isDocumentManagementEnabled;
            IsOneNoteIntegrationEnabled = isOneNoteIntegrationEnabled;
            IsInteractionCentricEnabled = isInteractionCentricEnabled;
            IsKnowledgeManagementEnabled = isKnowledgeManagementEnabled;
            IsSLAEnabled = isSLAEnabled;
            IsBPFEntity = isBPFEntity;
            IsDocumentRecommendationsEnabled = isDocumentRecommendationsEnabled;
            AutoCreateAccessTeams = autoCreateAccessTeams;
            IsActivity = isActivity;
            IsActivityParty = isActivityParty;
            IsAuditEnabled = isAuditEnabled;
            IsAvailableOffline = isAvailableOffline;
            IsChildEntity = isChildEntity;
            IsAIRUpdated = isAIRUpdated;
            IsValidForQueue = isValidForQueue;
            IsConnectionsEnabled = isConnectionsEnabled;
            IconLargeName = iconLargeName;
            IconMediumName = iconMediumName;
            IconSmallName = iconSmallName;
            IsCustomEntity = isCustomEntity;
            IsBusinessProcessEnabled = isBusinessProcessEnabled;
            IsCustomizable = isCustomizable;
            IsRenameable = isRenameable;
            IsMappable = isMappable;
            IsDuplicateDetectionEnabled = isDuplicateDetectionEnabled;
            CanCreateAttributes = canCreateAttributes;
            CanCreateForms = canCreateForms;
            CanCreateViews = canCreateViews;
            CanCreateCharts = canCreateCharts;
            CanBeRelatedEntityInRelationship = canBeRelatedEntityInRelationship;
            CanBePrimaryEntityInRelationship = canBePrimaryEntityInRelationship;
            CanBeInManyToMany = canBeInManyToMany;
            CanEnableSyncToExternalSearchIndex = canEnableSyncToExternalSearchIndex;
            SyncToExternalSearchIndex = syncToExternalSearchIndex;
            CanModifyAdditionalSettings = canModifyAdditionalSettings;
            CanChangeHierarchicalRelationship = canChangeHierarchicalRelationship;
            IsOptimisticConcurrencyEnabled = isOptimisticConcurrencyEnabled;
            ChangeTrackingEnabled = changeTrackingEnabled;
            CanChangeTrackingBeEnabled = canChangeTrackingBeEnabled;
            IsImportable = isImportable;
            IsIntersect = isIntersect;
            IsMailMergeEnabled = isMailMergeEnabled;
            IsManaged = isManaged;
            IsEnabledForCharts = isEnabledForCharts;
            IsEnabledForTrace = isEnabledForTrace;
            IsValidForAdvancedFind = isValidForAdvancedFind;
            IsVisibleInMobile = isVisibleInMobile;
            IsVisibleInMobileClient = isVisibleInMobileClient;
            IsReadOnlyInMobileClient = isReadOnlyInMobileClient;
            IsOfflineInMobileClient = isOfflineInMobileClient;
            DaysSinceRecordLastModified = daysSinceRecordLastModified;
            MobileOfflineFilters = mobileOfflineFilters;
            IsReadingPaneEnabled = isReadingPaneEnabled;
            IsQuickCreateEnabled = isQuickCreateEnabled;
            LogicalName = logicalName;
            ObjectTypeCode = objectTypeCode;
            OwnershipType = ownershipType;
            PrimaryNameAttribute = primaryNameAttribute;
            PrimaryImageAttribute = primaryImageAttribute;
            PrimaryIdAttribute = primaryIdAttribute;
            Privileges = privileges;
            RecurrenceBaseEntityLogicalName = recurrenceBaseEntityLogicalName;
            ReportViewName = reportViewName;
            SchemaName = schemaName;
            IntroducedVersion = introducedVersion;
            IsStateModelAware = isStateModelAware;
            EnforceStateTransitions = enforceStateTransitions;
            EntityColor = entityColor;
            LogicalCollectionName = logicalCollectionName;
            CollectionSchemaName = collectionSchemaName;
            EntitySetName = entitySetName;
            IsEnabledForExternalChannels = isEnabledForExternalChannels;
            IsPrivate = isPrivate;
            UsesBusinessDataLabelTable = usesBusinessDataLabelTable;
            IsLogicalEntity = isLogicalEntity;
            HasActivities = hasActivities;
            HasNotes = hasNotes;
            HasFeedback = hasFeedback;
            Attributes = attributes;
            ManyToManyRelationships = manyToManyRelationships;
            ManyToOneRelationships = manyToOneRelationships;
            OneToManyRelationships = oneToManyRelationships;
            Keys = keys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityTypeMask")]
        public int? ActivityTypeMask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AutoRouteToOwnerQueue")]
        public bool? AutoRouteToOwnerQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanTriggerWorkflow")]
        public bool? CanTriggerWorkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public MicrosoftDynamicsCRMLabel Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayCollectionName")]
        public MicrosoftDynamicsCRMLabel DisplayCollectionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public MicrosoftDynamicsCRMLabel DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityHelpUrlEnabled")]
        public bool? EntityHelpUrlEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityHelpUrl")]
        public string EntityHelpUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDocumentManagementEnabled")]
        public bool? IsDocumentManagementEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOneNoteIntegrationEnabled")]
        public bool? IsOneNoteIntegrationEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsInteractionCentricEnabled")]
        public bool? IsInteractionCentricEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsKnowledgeManagementEnabled")]
        public bool? IsKnowledgeManagementEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSLAEnabled")]
        public bool? IsSLAEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsBPFEntity")]
        public bool? IsBPFEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDocumentRecommendationsEnabled")]
        public bool? IsDocumentRecommendationsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AutoCreateAccessTeams")]
        public bool? AutoCreateAccessTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActivity")]
        public bool? IsActivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActivityParty")]
        public bool? IsActivityParty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAuditEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsAuditEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAvailableOffline")]
        public bool? IsAvailableOffline { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsChildEntity")]
        public bool? IsChildEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAIRUpdated")]
        public bool? IsAIRUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForQueue")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsValidForQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsConnectionsEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsConnectionsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconLargeName")]
        public string IconLargeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconMediumName")]
        public string IconMediumName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconSmallName")]
        public string IconSmallName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomEntity")]
        public bool? IsCustomEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsBusinessProcessEnabled")]
        public bool? IsBusinessProcessEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsCustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsRenameable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsRenameable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMappable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsMappable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDuplicateDetectionEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsDuplicateDetectionEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateAttributes")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanCreateAttributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateForms")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanCreateForms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateViews")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanCreateViews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateCharts")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanCreateCharts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeRelatedEntityInRelationship")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanBeRelatedEntityInRelationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBePrimaryEntityInRelationship")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanBePrimaryEntityInRelationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeInManyToMany")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanBeInManyToMany { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanEnableSyncToExternalSearchIndex")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanEnableSyncToExternalSearchIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SyncToExternalSearchIndex")]
        public bool? SyncToExternalSearchIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanModifyAdditionalSettings")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanModifyAdditionalSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanChangeHierarchicalRelationship")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanChangeHierarchicalRelationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOptimisticConcurrencyEnabled")]
        public bool? IsOptimisticConcurrencyEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChangeTrackingEnabled")]
        public bool? ChangeTrackingEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanChangeTrackingBeEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty CanChangeTrackingBeEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsImportable")]
        public bool? IsImportable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsIntersect")]
        public bool? IsIntersect { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMailMergeEnabled")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsMailMergeEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabledForCharts")]
        public bool? IsEnabledForCharts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabledForTrace")]
        public bool? IsEnabledForTrace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForAdvancedFind")]
        public bool? IsValidForAdvancedFind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsVisibleInMobile")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsVisibleInMobile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsVisibleInMobileClient")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsVisibleInMobileClient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReadOnlyInMobileClient")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsReadOnlyInMobileClient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOfflineInMobileClient")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsOfflineInMobileClient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DaysSinceRecordLastModified")]
        public int? DaysSinceRecordLastModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineFilters")]
        public string MobileOfflineFilters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReadingPaneEnabled")]
        public bool? IsReadingPaneEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsQuickCreateEnabled")]
        public bool? IsQuickCreateEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ObjectTypeCode")]
        public int? ObjectTypeCode { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'UserOwned',
        /// 'TeamOwned', 'BusinessOwned', 'OrganizationOwned',
        /// 'BusinessParented'
        /// </summary>
        [JsonProperty(PropertyName = "OwnershipType")]
        public string OwnershipType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryNameAttribute")]
        public string PrimaryNameAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryImageAttribute")]
        public string PrimaryImageAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryIdAttribute")]
        public string PrimaryIdAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Privileges")]
        public IList<MicrosoftDynamicsCRMSecurityPrivilegeMetadata> Privileges { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurrenceBaseEntityLogicalName")]
        public string RecurrenceBaseEntityLogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReportViewName")]
        public string ReportViewName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsStateModelAware")]
        public bool? IsStateModelAware { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnforceStateTransitions")]
        public bool? EnforceStateTransitions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityColor")]
        public string EntityColor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalCollectionName")]
        public string LogicalCollectionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CollectionSchemaName")]
        public string CollectionSchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntitySetName")]
        public string EntitySetName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabledForExternalChannels")]
        public bool? IsEnabledForExternalChannels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPrivate")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UsesBusinessDataLabelTable")]
        public bool? UsesBusinessDataLabelTable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsLogicalEntity")]
        public bool? IsLogicalEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasActivities")]
        public bool? HasActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasNotes")]
        public bool? HasNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasFeedback")]
        public bool? HasFeedback { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Attributes")]
        public IList<MicrosoftDynamicsCRMAttributeMetadata> Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManyToManyRelationships")]
        public IList<MicrosoftDynamicsCRMManyToManyRelationshipMetadata> ManyToManyRelationships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManyToOneRelationships")]
        public IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> ManyToOneRelationships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OneToManyRelationships")]
        public IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> OneToManyRelationships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keys")]
        public IList<MicrosoftDynamicsCRMEntityKeyMetadata> Keys { get; set; }

    }
}
