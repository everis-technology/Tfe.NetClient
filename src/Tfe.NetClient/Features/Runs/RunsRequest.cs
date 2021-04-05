namespace Tfe.NetClient.Runs
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// RunsRequest
    /// </summary>
    public partial class RunsRequest
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("data")]
        public RunsRequestData Data { get; } = new RunsRequestData();
    }

    /// <summary>
    /// RunsRequestData
    /// </summary>
    public partial class RunsRequestData
    {
        /// <summary>
        /// Attributes
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; } = new RequestAttributes();

        /// <summary>
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type => "runs";

        /// <summary>
        /// Relationships
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("relationships")]
        public RequestRelationships Relationships { get; } = new RequestRelationships();
    }

    /// <summary>
    /// RequestAttributes
    /// </summary>
    public partial class RequestAttributes
    {
        /// <summary>
        /// IsDestroy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("is-destroy")]
        public bool IsDestroy { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        /// <value></value>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// TargetAddrs
        /// </summary>
        /// <value></value>
        [JsonPropertyName("target-addrs")]
        public string[] TargetAddrs { get; set; }
    }

    /// <summary>
    /// RequestRelationships
    /// </summary>
    public partial class RequestRelationships
    {
        /// <summary>
        /// Workspace
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("workspace")]
        public ConfigurationData Workspace { get; } = new ConfigurationData();

        /// <summary>
        /// ConfigurationVersion
        /// </summary>
        /// <value></value>
        [JsonPropertyName("configuration-version")]
        public ConfigurationData ConfigurationVersion { get; set; }
    }

    /// <summary>
    /// ConfigurationData
    /// </summary>
    public partial class ConfigurationData
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("data")]
        public IdTypeData Data { get; } = new IdTypeData();
    }

    /// <summary>
    /// IdTypeData
    /// </summary>
    public partial class IdTypeData
    {
        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    /// <summary>
    /// CommentRequest
    /// </summary>
    public class CommentRequest
    {
        /// <summary>
        /// Comment
        /// </summary>
        /// <value></value>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
