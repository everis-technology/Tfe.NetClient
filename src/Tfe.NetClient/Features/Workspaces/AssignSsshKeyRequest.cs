namespace Tfe.NetClient.Workspaces
{
    using System.Text.Json.Serialization;

    public partial class AssignSsshKeyRequest
    {
        [JsonPropertyName("data")]
        public AssignSsshKeyData Data { get; } = new AssignSsshKeyData();
    }

    public partial class AssignSsshKeyData
    {
        [JsonPropertyName("attributes")]
        public AssignSsshKeyAttributes Attributes { get; } = new AssignSsshKeyAttributes();

        [JsonPropertyName("type")]
        public string Type { get; } = "workspaces";
    }

    public partial class AssignSsshKeyAttributes
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
