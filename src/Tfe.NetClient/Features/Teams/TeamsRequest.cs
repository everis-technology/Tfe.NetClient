namespace Tfe.NetClient.Teams
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// TeamsRequest
    /// </summary>
    public class TeamsRequest
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class Data
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
        public RequestAttributes Attributes { get; set; }
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
        /// OrganizationAccess
        /// </summary>
        /// <value></value>
        [JsonPropertyName("organization-access")]
        public RequestOrganizationAccess OrganizationAccess { get; set; }
    }

    /// <summary>
    /// RequestOrganizationAccess
    /// </summary>
    public class RequestOrganizationAccess
    {
        /// <summary>
        /// ManageWorkspaces
        /// </summary>
        /// <value></value>
        [JsonPropertyName("manage-workspaces")]
        public bool ManageWorkspaces { get; set; }
    }
}
