namespace Tfe.NetClient.WorkspaceVariables
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// WorkspaceVariablesRequest
    /// </summary>
    public class WorkspaceVariablesRequest
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("data")]
        public RequestData Data { get; } = new RequestData();
    }

    /// <summary>
    /// RequestData
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type => "vars";

        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("Id")]
        public string id { get; set; }

        /// <summary>
        /// Attributes
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; } = new RequestAttributes();
    }

    /// <summary>
    /// RequestAttributes
    /// </summary>
    public class RequestAttributes
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

        /// <summary>
        /// Sensitive
        /// </summary>
        /// <value></value>
        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }
    }
}
