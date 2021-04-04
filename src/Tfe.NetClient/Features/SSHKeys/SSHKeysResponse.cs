namespace Tfe.NetClient.SshKeys
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// SshKeysResponse
    /// </summary>
    public class SshKeysResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    /// <summary>
    /// SshKeyResponse
    /// </summary>
    public class SshKeyResponse
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
        /// Attributes
        /// </summary>
        /// <value></value>
        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public Links Links { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ResponseAttributes
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <value></value>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    /// <summary>
    /// Links
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}
