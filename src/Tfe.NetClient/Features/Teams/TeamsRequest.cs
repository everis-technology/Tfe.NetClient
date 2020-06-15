namespace Tfe.NetClient.Teams
{
    using System.Text.Json.Serialization;

    public class TeamsRequest
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; set; }
    }

    public class RequestAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("organization-access")]
        public RequestOrganizationAccess OrganizationAccess { get; set; }
    }

    public class RequestOrganizationAccess
    {
        [JsonPropertyName("manage-workspaces")]
        public bool ManageWorkspaces { get; set; }
    }
}
