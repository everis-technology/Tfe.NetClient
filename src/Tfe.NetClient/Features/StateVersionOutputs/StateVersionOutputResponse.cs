namespace Tfe.NetClient.StateVersionOutputs
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// StateVersionOutputResponse
    /// </summary>
    public partial class StateVersionOutputResponse
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
    public partial class Data
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
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    /// <summary>
    /// Attributes
    /// </summary>
    public partial class Attributes
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <value></value>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Sensitive
        /// </summary>
        /// <value></value>
        [JsonPropertyName("sensitive")]
        public bool Sensitive { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value></value>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    /// <summary>
    /// Links
    /// </summary>
    public partial class Links
    {   
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}
