namespace Tfe.NetClient.OAuthClients
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public class OAuthClientsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    public class OAuthClientResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }

    public class ResponseDatum
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ResponseAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("callback-url")]
        public Uri CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("connect-path")]
        public string ConnectPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("service-provider")]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("service-provider-display-name")]
        public string ServiceProviderDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public object Name { get; set; }

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
        [JsonPropertyName("key")]
        public object Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rsa-public-key")]
        public object RsaPublicKey { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("organization")]
        public ResponseOrganization Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("oauth-tokens")]
        public OAuthTokens OAuthTokens { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class OAuthTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("data")]
        public Data[] Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Links
    {
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ResponseOrganization
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
