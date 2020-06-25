namespace Tfe.NetClient.TeamWorkspaces
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// TeamWorkspacesResponse
    /// </summary>
    public partial class TeamWorkspacesResponse
    {   
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Datum[] Data { get; set; }
    }

    /// <summary>
    /// Datum
    /// </summary>
    public partial class Datum
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
        public Attributes Attributes { get; set; }

        /// <summary>
        /// Relationships
        /// </summary>
        /// <value></value>
        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
        
        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public DatumLinks Links { get; set; }
    }

    /// <summary>
    /// Attributes
    /// </summary>
    public partial class Attributes
    {
        /// <summary>
        /// Access
        /// </summary>
        /// <value></value>
        [JsonPropertyName("access")]
        public string Access { get; set; }

        /// <summary>
        /// Runs
        /// </summary>
        /// <value></value>
        [JsonPropertyName("runs")]
        public string Runs { get; set; }

        /// <summary>
        /// Variables
        /// </summary>
        /// <value></value>
        [JsonPropertyName("variables")]
        public string Variables { get; set; }

        /// <summary>
        /// StateVersions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("state-versions")]
        public string StateVersions { get; set; }

        /// <summary>
        /// SentinelMocks
        /// </summary>
        /// <value></value>
        [JsonPropertyName("sentinel-mocks")]
        public string SentinelMocks { get; set; }

        /// <summary>
        /// WorkspaceLocking
        /// </summary>
        /// <value></value>
        [JsonPropertyName("workspace-locking")]
        public bool WorkspaceLocking { get; set; }
    }

    /// <summary>
    /// DatumLinks
    /// </summary>
    public partial class DatumLinks
    {
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    /// <summary>
    /// Relationships
    /// </summary>
    public partial class Relationships
    {   
        /// <summary>
        /// Team
        /// </summary>
        /// <value></value>
        [JsonPropertyName("team")]
        public Team Team { get; set; }

        /// <summary>
        /// Workspace
        /// </summary>
        /// <value></value>
        [JsonPropertyName("workspace")]
        public Team Workspace { get; set; }
    }

    /// <summary>
    /// Team
    /// </summary>
    public partial class Team
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public TeamLinks Links { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public partial class Data
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
    }

    /// <summary>
    /// TeamLinks
    /// </summary>
    public partial class TeamLinks
    {
        /// <summary>
        /// Related
        /// </summary>
        /// <value></value>
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }
}
