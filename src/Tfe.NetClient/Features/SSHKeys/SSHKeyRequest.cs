namespace Tfe.NetClient.SshKeys
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// SshKeyRequest
    /// </summary>
    public class SshKeyRequest
    {
        /// <summary>
        /// SshKeyRequest
        /// </summary>
        public SshKeyRequest()
        {
            this.Data = new RequestData();
        }

        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public RequestData Data { get; }
    }

    /// <summary>
    /// RequestData
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// RequestData
        /// </summary>
        public RequestData()
        {
            this.Attributes = new RequestAttributes();
        }

        /// <summary>
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type => "ssh-keys";

        /// <summary>
        /// Attributes
        /// </summary>
        /// <value></value>
        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; }
    }

    /// <summary>
    /// RequestAttributes
    /// </summary>
    public class RequestAttributes
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <value></value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value></value>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
