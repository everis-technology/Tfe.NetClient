namespace Tfe.NetClient.Organizations
{
    using System;
    using System.Text.Json.Serialization;

    public class OrganizationsResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    public class OrganizationResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }

    public class ResponseDatum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ResponseAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cost-estimation-enabled")]
        public bool CostEstimationEnabled { get; set; }

        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("session-timeout")]
        public object SessionTimeout { get; set; }

        [JsonPropertyName("session-remember")]
        public object SessionRemember { get; set; }

        [JsonPropertyName("collaborator-auth-policy")]
        public string CollaboratorAuthPolicy { get; set; }

        [JsonPropertyName("enterprise-plan")]
        public string EnterprisePlan { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }
    }

    public class Permissions
    {
        [JsonPropertyName("can-update")]
        public bool CanUpdate { get; set; }

        [JsonPropertyName("can-destroy")]
        public bool CanDestroy { get; set; }

        [JsonPropertyName("can-create-team")]
        public bool CanCreateTeam { get; set; }

        [JsonPropertyName("can-create-workspace")]
        public bool CanCreateWorkspace { get; set; }

        [JsonPropertyName("can-update-oauth")]
        public bool CanUpdateOauth { get; set; }

        [JsonPropertyName("can-update-api-token")]
        public bool CanUpdateApiToken { get; set; }

        [JsonPropertyName("can-update-sentinel")]
        public bool CanUpdateSentinel { get; set; }

        [JsonPropertyName("can-traverse")]
        public bool CanTraverse { get; set; }

        [JsonPropertyName("can-create-workspace-migration")]
        public bool CanCreateWorkspaceMigration { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}
