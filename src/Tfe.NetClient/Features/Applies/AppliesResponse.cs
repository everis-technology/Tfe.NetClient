namespace Tfe.NetClient.Applies
{
    using System;
    using System.Text.Json.Serialization;
    
    /// <summary>
    /// ApplyResponse
    /// </summary>
    public class ApplyResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
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
        /// <value></value>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    /// <summary>
    /// Attributes
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// Status
        /// </summary>
        /// <value></value>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// StatusTimestamps
        /// </summary>
        /// <value></value>
        [JsonPropertyName("status-timestamps")]
        public StatusTimestamps StatusTimestamps { get; set; }

        /// <summary>
        /// LogReadUrl
        /// </summary>
        /// <value></value>
        [JsonPropertyName("log-read-url")]
        public Uri LogReadUrl { get; set; }

        /// <summary>
        /// ResourceAdditions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("resource-additions")]
        public long ResourceAdditions { get; set; }

        /// <summary>
        /// ResourceChanges
        /// </summary>
        /// <value></value>
        [JsonPropertyName("resource-changes")]
        public long ResourceChanges { get; set; }

        /// <summary>
        /// ResourceDestructions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("resource-destructions")]
        public long ResourceDestructions { get; set; }
    }

    /// <summary>
    /// StatusTimestamps
    /// </summary>
    public class StatusTimestamps
    {
        /// <summary>
        /// QueuedAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("queued-at")]
        public DateTimeOffset QueuedAt { get; set; }

        /// <summary>
        /// StartedAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("started-at")]
        public DateTimeOffset StartedAt { get; set; }

        /// <summary>
        /// FinishedAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("finished-at")]
        public DateTimeOffset FinishedAt { get; set; }
    }

    /// <summary>
    /// Links
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    /// <summary>
    /// Relationships
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// StateVersions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("state-versions")]
        public StateVersions StateVersions { get; set; }
    }

    /// <summary>
    /// StateVersions
    /// </summary>
    public class StateVersions
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Datum[] Data { get; set; }
    }

    /// <summary>
    /// Datum
    /// </summary>
    public class Datum
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
