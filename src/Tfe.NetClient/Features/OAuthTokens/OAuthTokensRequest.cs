namespace Tfe.NetClient.OAuthTokens
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// OAuthTokensRequest
    /// </summary>
    public class OAuthTokensRequest
    {
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public RequestData Data { get; } = new RequestData();
    }

    /// <summary>
    /// RequestData
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type => "oauth-tokens";

        /// <summary>
        /// Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public RequestDataAttributes Attributes { get; } = new RequestDataAttributes();
    }

    /// <summary>
    /// RequestDataAttributes
    /// </summary>
    public class RequestDataAttributes
    {
        /// <summary>
        /// SSHKey
        /// </summary>
        [JsonPropertyName("ssh-key")]
        public string SSHKey { get; set; }
    }
}