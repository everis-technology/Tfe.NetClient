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
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseData[] Data { get; set; }
    }

    /// <summary>
    /// OAuthTokenResponse
    /// </summary>
    public class OAuthTokenResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseData Data { get; set; }
    }

    /// <summary>
    /// ResponseData
    /// </summary>
    public class ResponseData
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
        /// <value></value>
        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// Relationships
        /// </summary>
        /// <value></value>
        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }

    }

    /// <summary>
    /// Attributes
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// CreatedAt
        /// </summary>
        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// ServiceProvider
        /// </summary>
        [JsonPropertyName("service-provider-user")]
        public string ServiceProviderUser { get; set; }

        /// <summary>
        /// ServiceProvider
        /// </summary>
        [JsonPropertyName("has-ssh-key")]
        public bool HasSshKey { get; set; }
        
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
        public ResponseOauthClient OAuthClient { get; set; }
    }

    /// <summary>
    /// OAuthClients
    /// </summary>
    public class ResponseOauthClient
    {
        /// <summary>
        /// Data
        /// </summary>
        [JsonPropertyName("data")]
        public OauthClientData OauthClientData { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class OauthClientData
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
}
