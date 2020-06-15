namespace Tfe.NetClient.Organizations
{
    using System.Text.Json.Serialization;

    public class OrganizationRequest
    {
        [JsonPropertyName("data")]
        public RequestDatum Data { get; set; }
    }

    public class RequestDatum
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }
    }

    public class RequestAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cost-estimation-enabled")]
        public bool CostEstimationEnabled { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("session-timeout")]
        public object SessionTimeout { get; set; }

        [JsonPropertyName("session-remember")]
        public object SessionRemember { get; set; }

        [JsonPropertyName("collaborator-auth-policy")]
        public string CollaboratorAuthPolicy { get; set; }

        [JsonPropertyName("owners-team-saml-role-id")]
        public string OwnersTeamSAMLRoleId { get; set; }
    }
}