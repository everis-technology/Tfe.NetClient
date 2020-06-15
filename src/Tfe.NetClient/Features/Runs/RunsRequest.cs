namespace Tfe.NetClient.Runs
{
    using System.Text.Json.Serialization;

    public partial class RunsRequest
    {
        [JsonPropertyName("data")]
        public RunsRequestData Data { get; } = new RunsRequestData();
    }

    public partial class RunsRequestData
    {
        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; } = new RequestAttributes();

        [JsonPropertyName("type")]
        public string Type => "runs";

        [JsonPropertyName("relationships")]
        public RequestRelationships Relationships { get; } = new RequestRelationships();
    }

    public partial class RequestAttributes
    {
        [JsonPropertyName("is-destroy")]
        public bool IsDestroy { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("target-addrs")]
        public string[] TargetAddrs { get; set; }
    }

    public partial class RequestRelationships
    {
        [JsonPropertyName("workspace")]
        public ConfigurationData Workspace { get; } = new ConfigurationData();

        [JsonPropertyName("configuration-version")]
        public ConfigurationData ConfigurationVersion { get; set; }
    }

    public partial class ConfigurationData
    {
        [JsonPropertyName("data")]
        public IdTypeData Data { get; } = new IdTypeData();
    }

    public partial class IdTypeData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class CommentRequest
    {
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
