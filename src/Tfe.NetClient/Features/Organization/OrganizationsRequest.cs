namespace Tfe.NetClient.Organizations
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// OrganizationRequest
    /// </summary>
    public class OrganizationRequest
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public RequestDatum Data { get; set; }
    }

    /// <summary>
    /// RequestDatum
    /// </summary>
    public class RequestDatum
    {
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
    }

    /// <summary>
    /// RequestAttributes
    /// </summary>
    public class RequestAttributes
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
        /// OwnersTeamSAMLRoleId
        /// </summary>
        /// <value></value>
        [JsonPropertyName("owners-team-saml-role-id")]
        public string OwnersTeamSAMLRoleId { get; set; }
    }
}