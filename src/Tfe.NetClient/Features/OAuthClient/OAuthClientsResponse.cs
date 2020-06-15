namespace Tfe.NetClient.OAuthClients
{
    using System;
    using System.Text.Json.Serialization;

    public class OAuthClientsResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    public class OAuthClientResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }

    public class ResponseDatum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class ResponseAttributes
    {
        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("callback-url")]
        public Uri CallbackUrl { get; set; }

        [JsonPropertyName("connect-path")]
        public string ConnectPath { get; set; }

        [JsonPropertyName("service-provider")]
        public string ServiceProvider { get; set; }

        [JsonPropertyName("service-provider-display-name")]
        public string ServiceProviderDisplayName { get; set; }

        [JsonPropertyName("name")]
        public object Name { get; set; }

        [JsonPropertyName("http-url")]
        public Uri HttpUrl { get; set; }

        [JsonPropertyName("api-url")]
        public Uri ApiUrl { get; set; }

        [JsonPropertyName("key")]
        public object Key { get; set; }

        [JsonPropertyName("rsa-public-key")]
        public object RsaPublicKey { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("organization")]
        public ResponseOrganization Organization { get; set; }

        [JsonPropertyName("oauth-tokens")]
        public OAuthTokens OAuthTokens { get; set; }
    }

    public class OAuthTokens
    {
        [JsonPropertyName("data")]
        public Data[] Data { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class ResponseOrganization
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
