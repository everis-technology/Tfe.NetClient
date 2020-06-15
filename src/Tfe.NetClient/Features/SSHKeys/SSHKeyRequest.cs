namespace Tfe.NetClient.SshKeys
{
    using System.Text.Json.Serialization;

    public class SshKeyRequest
    {
        public SshKeyRequest()
        {
            this.Data = new RequestData();
        }

        [JsonPropertyName("data")]
        public RequestData Data { get; }
    }

    public class RequestData
    {
        public RequestData()
        {
            this.Attributes = new RequestAttributes();
        }

        [JsonPropertyName("type")]
        public string Type => "ssh-keys";

        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; }
    }

    public class RequestAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
