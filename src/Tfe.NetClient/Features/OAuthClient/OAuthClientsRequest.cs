namespace Tfe.NetClient.OAuthClients
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public class OAuthClientsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("data")]
        public RequestData Data { get; } = new RequestData();
    }

    /// <summary>
    /// 
    /// </summary>

    public class RequestData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public string Type => "oauth-clients";

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("attributes")]
        public RequestDataAttributes Attributes { get; } = new RequestDataAttributes();
    }

    /// <summary>
    /// 
    /// </summary>
    public class RequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("service-provider")]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("http-url")]
        public Uri HttpUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("api-url")]
        public Uri ApiUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("oauth-token-string")]
        public string OAuthTokenString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("private-key")]
        public string PrivateKey { get; set; }
    }
}