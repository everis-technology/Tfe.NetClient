namespace Tfe.NetClient.WorkspaceVariables
{
    using System.Text.Json.Serialization;

    public class WorkspaceVariablesRequest
    {
        [JsonPropertyName("data")]
        public RequestData Data { get; } = new RequestData();
    }

    public class RequestData
    {
        [JsonPropertyName("type")]
        public string Type => "vars";

        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; } = new RequestAttributes();
    }

    public class RequestAttributes
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("hcl")]
        public bool Hcl { get; set; }

        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }
    }
}
