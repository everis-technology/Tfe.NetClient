namespace Tfe.NetClient.TeamWorkspaces
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// TeamWorkspacesResponse
    /// </summary>
    public class TeamWorkspacesResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Data[] Data { get; set; }
    }

    /// <summary>
    /// TeamWorkspaceResponse
    /// </summary>
    public class TeamWorkspaceResponse
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
    public class Attributes
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
    public class Relationships
    {
        /// <summary>
        /// Team
        /// </summary>
        /// <value></value>
        [JsonPropertyName("team")]
        public Relationship Team { get; set; }

        /// <summary>
        /// Workspace
        /// </summary>
        /// <value></value>
        [JsonPropertyName("workspace")]
        public Relationship Workspace { get; set; }
    }

    /// <summary>
    /// Relationship
    /// </summary>
    public class Relationship
    {
        /// <summary>
        /// RelationshipData
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public RelationshipData RelationshipData { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public RelationshipLinks Links { get; set; }
    }

    /// <summary>
    /// RelationshipData
    /// </summary>
    public class RelationshipData
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
    /// RelationshipLinks
    /// </summary>
    public class RelationshipLinks
    {
        /// <summary>
        /// Related
        /// </summary>
        /// <value></value>
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }
}
