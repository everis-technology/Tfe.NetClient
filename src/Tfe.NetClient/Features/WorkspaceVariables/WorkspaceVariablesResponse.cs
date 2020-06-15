namespace Tfe.NetClient.WorkspaceVariables
{
    using System.Text.Json.Serialization;

    public class WorkspaceVariablesResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    public class WorkspaceVariableResponse
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

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public DatumLinks Links { get; set; }
    }

    public class ResponseAttributes
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("hcl")]
        public bool Hcl { get; set; }
    }

    public class DatumLinks
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("configurable")]
        public Configurable Configurable { get; set; }
    }

    public class Configurable
    {
        [JsonPropertyName("data")]
        public ResponseData Data { get; set; }

        [JsonPropertyName("links")]
        public ConfigurableLinks Links { get; set; }
    }

    public class ResponseData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class ConfigurableLinks
    {
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }
}
