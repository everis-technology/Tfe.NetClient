namespace Tfe.NetClient.OAuthTokens
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// OAuthTokensResponse
    /// </summary>
    public class OAuthTokensResponse
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
    public class OAuthTokenResponse
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

        /// <summary>
        /// Links
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }

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
        /// ServiceProvider
        /// </summary>
        [JsonPropertyName("service-provider-user")]
        public string ServiceProviderUser { get; set; }

        /// <summary>
        /// ServiceProviderDisplayName
        /// </summary>
        [JsonPropertyName("has-ssh-key")]
        public bool HasSSHKey { get; set; }
    }

    /// <summary>
    /// Relationships
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// OAuthClients
        /// </summary>
        [JsonPropertyName("oauth-client")]
        public OAuthClients OAuthClients { get; set; }
    }

    /// <summary>
    /// OAuthClients
    /// </summary>
    public class OAuthClients
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

        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

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
