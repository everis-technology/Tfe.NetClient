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
        public OAuthTokensRequestData Data { get; } = new OAuthTokensRequestData();
    }

    /// <summary>
    /// RequestData
    /// </summary>
    public class OAuthTokensRequestData
    {
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
        /// Sshkey
        /// </summary>
        [JsonPropertyName("ssh-key")]
        public string Sshkey { get; set; }
    }
}