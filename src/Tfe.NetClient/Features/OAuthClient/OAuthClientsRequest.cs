namespace Tfe.NetClient.OAuthClients
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// OAuthClientsRequest
    /// </summary>
    public class OAuthClientsRequest
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
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type => "oauth-clients";

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
        /// ServiceProvider
        /// </summary>
        [JsonPropertyName("service-provider")]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// HttpUrl
        /// </summary>
        [JsonPropertyName("http-url")]
        public Uri HttpUrl { get; set; }

        /// <summary>
        /// ApiUrl
        /// </summary>
        [JsonPropertyName("api-url")]
        public Uri ApiUrl { get; set; }

        /// <summary>
        /// OAuthTokenString
        /// </summary>
        [JsonPropertyName("oauth-token-string")]
        public string OAuthTokenString { get; set; }

        /// <summary>
        /// PrivateKey
        /// </summary>
        [JsonPropertyName("private-key")]
        public string PrivateKey { get; set; }
    }
}