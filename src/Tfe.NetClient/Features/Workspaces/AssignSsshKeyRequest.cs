namespace Tfe.NetClient.Workspaces
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// AssignSsshKeyRequest
    /// </summary>
    public partial class AssignSsshKeyRequest
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("data")]
        public AssignSsshKeyData Data { get; } = new AssignSsshKeyData();
    }

    /// <summary>
    /// AssignSsshKeyData
    /// </summary>
    public partial class AssignSsshKeyData
    {   
        /// <summary>
        /// Attributes
        /// </summary>
        /// <returns></returns>
        [JsonPropertyName("attributes")]
        public AssignSsshKeyAttributes Attributes { get; } = new AssignSsshKeyAttributes();

        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; } = "workspaces";
    }

    /// <summary>
    /// AssignSsshKeyAttributes
    /// </summary>
    public partial class AssignSsshKeyAttributes
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
