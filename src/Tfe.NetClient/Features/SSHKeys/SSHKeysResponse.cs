namespace Tfe.NetClient.SshKeys
{
    using System.Text.Json.Serialization;

    public class SshKeysResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    public class SshKeyResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }


    public class ResponseDatum
    {
        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class ResponseAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}
