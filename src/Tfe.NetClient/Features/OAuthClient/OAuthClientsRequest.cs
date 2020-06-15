namespace Tfe.NetClient.OAuthClients
{
    using System;
    using System.Text.Json.Serialization;

    public class OAuthClientsRequest
    {

        [JsonPropertyName("data")]
        public RequestData Data { get; } = new RequestData();
    }

    public class RequestData
    {
        [JsonPropertyName("type")]
        public string Type => "oauth-clients";

        [JsonPropertyName("attributes")]
        public RequestDataAttributes Attributes { get; } = new RequestDataAttributes();
    }

    public class RequestDataAttributes
    {
        [JsonPropertyName("service-provider")]
        public string ServiceProvider { get; set; }

        [JsonPropertyName("http-url")]
        public Uri HttpUrl { get; set; }

        [JsonPropertyName("api-url")]
        public Uri ApiUrl { get; set; }

        [JsonPropertyName("oauth-token-string")]
        public string OAuthTokenString { get; set; }

        [JsonPropertyName("private-key")]
        public string PrivateKey { get; set; }
    }
}
