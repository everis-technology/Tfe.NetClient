namespace Tfe.NetClient.WorkspaceVariables
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// WorkspaceVariablesResponse
    /// </summary>
    public class WorkspaceVariablesResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class WorkspaceVariableResponse
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
    /// ResponseAttributes
    /// </summary>
    public class ResponseAttributes
    {
        /// <summary>
        /// Key
        /// </summary>
        /// <value></value>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value></value>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value></value>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Sensitive
        /// </summary>
        /// <value></value>
        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        /// <value></value>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Hcl
        /// </summary>
        /// <value></value>
        [JsonPropertyName("hcl")]
        public bool Hcl { get; set; }
    }

    /// <summary>
    /// DatumLinks
    /// </summary>
    public class DatumLinks
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
        /// Configurable
        /// </summary>
        /// <value></value>
        [JsonPropertyName("configurable")]
        public Configurable Configurable { get; set; }
    }

    /// <summary>
    /// Configurable
    /// </summary>
    public class Configurable
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseData Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public ConfigurableLinks Links { get; set; }
    }

    /// <summary>
    /// ResponseData
    /// </summary>
    public class ResponseData
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
    /// ConfigurableLinks
    /// </summary>
    public class ConfigurableLinks
    {
        /// <summary>
        /// Related
        /// </summary>
        /// <value></value>
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }
}
