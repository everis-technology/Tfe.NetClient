namespace Tfe.NetClient.StateVersions
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// StateVersionRequest
    /// </summary>
    public class StateVersionRequest
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public StateVersionRequestData Data { get; set; }
    }

    /// <summary>
    /// StateVersionRequestData
    /// </summary>
    public class StateVersionRequestData
    {
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
    }

    /// <summary>
    /// Attributes
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// Serial
        /// </summary>
        /// <value></value>
        [JsonPropertyName("serial")]
        public long Serial { get; set; }

        /// <summary>
        /// Md5
        /// </summary>
        /// <value></value>
        [JsonPropertyName("md5")]
        public string Md5 { get; set; }

        /// <summary>
        /// Lineage
        /// </summary>
        /// <value></value>
        [JsonPropertyName("lineage")]
        public Guid Lineage { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value></value>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }

    /// <summary>
    /// Relationships
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// Run
        /// </summary>
        /// <value></value>
        [JsonPropertyName("run")]
        public StateRun Run { get; set; }
    }

    /// <summary>
    /// StateRun
    /// </summary>
    public class StateRun
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public RunData Data { get; set; }
    }

    /// <summary>
    /// RunData
    /// </summary>
    public class RunData
    {
        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
