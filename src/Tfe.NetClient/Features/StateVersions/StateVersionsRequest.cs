namespace Tfe.NetClient.StateVersions
{
    using System;
    using System.Text.Json.Serialization;

    public class StateVersionRequest
    {
        [JsonPropertyName("data")]
        public StateVersionRequestData Data { get; set; }
    }

    public class StateVersionRequestData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("serial")]
        public long Serial { get; set; }

        [JsonPropertyName("md5")]
        public string Md5 { get; set; }

        [JsonPropertyName("lineage")]
        public Guid Lineage { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("run")]
        public StateRun Run { get; set; }
    }

    public class StateRun
    {
        [JsonPropertyName("data")]
        public RunData Data { get; set; }
    }

    public class RunData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
