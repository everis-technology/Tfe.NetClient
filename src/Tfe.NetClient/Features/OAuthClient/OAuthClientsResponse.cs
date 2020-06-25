namespace Tfe.NetClient.OAuthClients
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// OAuthClientsResponse
    /// </summary>
    public class OAuthClientsResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class OAuthClientResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }

    /// <summary>
    /// ResponseDatum
    /// </summary>
    public class ResponseDatum
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
        public string Type { get; set; }
        
        /// <summary>
        /// Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        /// <summary>
        /// Relationships
        /// </summary>
        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    /// <summary>
    /// ResponseAttributes
    /// </summary>
    public class ResponseAttributes
    {
        /// <summary>
        /// CreatedAt
        /// </summary>
        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// CallbackUrl
        /// </summary>
        [JsonPropertyName("callback-url")]
        public Uri CallbackUrl { get; set; }

        /// <summary>
        /// ConnectPath
        /// </summary>
        [JsonPropertyName("connect-path")]
        public string ConnectPath { get; set; }

        /// <summary>
        /// ServiceProvider
        /// </summary>
        [JsonPropertyName("service-provider")]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// ServiceProviderDisplayName
        /// </summary>
        [JsonPropertyName("service-provider-display-name")]
        public string ServiceProviderDisplayName { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public object Name { get; set; }

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
        /// Key
        /// </summary>
        [JsonPropertyName("key")]
        public object Key { get; set; }

        /// <summary>
        /// RsaPublicKey
        /// </summary>
        [JsonPropertyName("rsa-public-key")]
        public object RsaPublicKey { get; set; }
    }

    /// <summary>
    /// Relationships
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// Organization
        /// </summary>
        [JsonPropertyName("organization")]
        public ResponseOrganization Organization { get; set; }

        /// <summary>
        /// OAuthTokens
        /// </summary>
        [JsonPropertyName("oauth-tokens")]
        public OAuthTokens OAuthTokens { get; set; }
    }

    /// <summary>
    /// OAuthTokens
    /// </summary>
    public class OAuthTokens
    {
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public Data[] Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    /// <summary>
    /// Links
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Related
        /// </summary>
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    /// <summary>
    /// ResponseOrganization
    /// </summary>
    public class ResponseOrganization
    {
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
    /// <summary>
    /// Data
    /// </summary>
    public class Data
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
        public string Type { get; set; }
    }
}
