namespace Tfe.NetClient.Applies
{
    using System;
    using System.Text.Json.Serialization;

    public class ApplyResponse
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("status-timestamps")]
        public StatusTimestamps StatusTimestamps { get; set; }

        [JsonPropertyName("log-read-url")]
        public Uri LogReadUrl { get; set; }

        [JsonPropertyName("resource-additions")]
        public long ResourceAdditions { get; set; }

        [JsonPropertyName("resource-changes")]
        public long ResourceChanges { get; set; }

        [JsonPropertyName("resource-destructions")]
        public long ResourceDestructions { get; set; }
    }

    public class StatusTimestamps
    {
        [JsonPropertyName("queued-at")]
        public DateTimeOffset QueuedAt { get; set; }

        [JsonPropertyName("started-at")]
        public DateTimeOffset StartedAt { get; set; }

        [JsonPropertyName("finished-at")]
        public DateTimeOffset FinishedAt { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("state-versions")]
        public StateVersions StateVersions { get; set; }
    }

    public class StateVersions
    {
        [JsonPropertyName("data")]
        public Datum[] Data { get; set; }
    }

    public class Datum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
