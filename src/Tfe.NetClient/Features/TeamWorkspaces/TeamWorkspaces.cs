namespace Tfe.NetClient.TeamWorkspaces
{
    using System.Text.Json.Serialization;

    public partial class TeamWorkspacesResponse
    {
        [JsonPropertyName("data")]
        public Datum[] Data { get; set; }
    }

    public partial class Datum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public DatumLinks Links { get; set; }
    }

    public partial class Attributes
    {
        [JsonPropertyName("access")]
        public string Access { get; set; }

        [JsonPropertyName("runs")]
        public string Runs { get; set; }

        [JsonPropertyName("variables")]
        public string Variables { get; set; }

        [JsonPropertyName("state-versions")]
        public string StateVersions { get; set; }

        [JsonPropertyName("sentinel-mocks")]
        public string SentinelMocks { get; set; }

        [JsonPropertyName("workspace-locking")]
        public bool WorkspaceLocking { get; set; }
    }

    public partial class DatumLinks
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    public partial class Relationships
    {
        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("workspace")]
        public Team Workspace { get; set; }
    }

    public partial class Team
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("links")]
        public TeamLinks Links { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public partial class TeamLinks
    {
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }
}
