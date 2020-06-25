namespace Tfe.NetClient.Organizations
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// OrganizationsResponse
    /// </summary>
    public class OrganizationsResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    /// <summary>
    /// OrganizationResponse
    /// </summary>
    public class OrganizationResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }

    /// <summary>
    /// ResponseDatum
    /// </summary>
    public class ResponseDatum
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Attributes
        /// </summary>
        /// <value></value>
        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    /// <summary>
    /// ResponseAttributes
    /// </summary>
    public class ResponseAttributes
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <value></value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// CostEstimationEnabled
        /// </summary>
        /// <value></value>
        [JsonPropertyName("cost-estimation-enabled")]
        public bool CostEstimationEnabled { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value></value>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// SessionTimeout
        /// </summary>
        /// <value></value>
        [JsonPropertyName("session-timeout")]
        public object SessionTimeout { get; set; }

        /// <summary>
        /// SessionRemember
        /// </summary>
        /// <value></value>
        [JsonPropertyName("session-remember")]
        public object SessionRemember { get; set; }

        /// <summary>
        /// CollaboratorAuthPolicy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("collaborator-auth-policy")]
        public string CollaboratorAuthPolicy { get; set; }

        /// <summary>
        /// EnterprisePlan
        /// </summary>
        /// <value></value>
        [JsonPropertyName("enterprise-plan")]
        public string EnterprisePlan { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }
    }

    /// <summary>
    /// Permissions
    /// </summary>
    public class Permissions
    {
        /// <summary>
        /// CanUpdate
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update")]
        public bool CanUpdate { get; set; }

        /// <summary>
        /// CanDestroy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-destroy")]
        public bool CanDestroy { get; set; }

        /// <summary>
        /// CanCreateTeam
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-create-team")]
        public bool CanCreateTeam { get; set; }

        /// <summary>
        /// CanCreateWorkspace
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-create-workspace")]
        public bool CanCreateWorkspace { get; set; }

        /// <summary>
        /// CanUpdateOauth
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-oauth")]
        public bool CanUpdateOauth { get; set; }

        /// <summary>
        /// CanUpdateApiToken
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-api-token")]
        public bool CanUpdateApiToken { get; set; }

        /// <summary>
        /// CanUpdateSentinel
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-sentinel")]
        public bool CanUpdateSentinel { get; set; }

        /// <summary>
        /// CanTraverse
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-traverse")]
        public bool CanTraverse { get; set; }
        
        /// <summary>
        /// CanCreateWorkspaceMigration
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-create-workspace-migration")]
        public bool CanCreateWorkspaceMigration { get; set; }
    }

    /// <summary>
    /// Links
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}
