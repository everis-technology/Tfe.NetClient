namespace Tfe.NetClient.Workspaces
{
    using System.Text.Json.Serialization;

    public class WorkspacesRequest
    {
        public WorkspacesRequest()
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

        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; }

        [JsonPropertyName("type")]
        public string Type => "workspaces";
    }

    public class RequestAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("terraform_version")]
        public string TerraformVersion { get; set; }

        [JsonPropertyName("trigger-prefixes")]
        public string[] TriggerPrefixes { get; set; }

        [JsonPropertyName("working-directory")]
        public string WorkingDirectory { get; set; }

        [JsonPropertyName("vcs-repo")]
        public RequestVcsRepo VcsRepo { get; set; }
    }

    public class RequestVcsRepo
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("oauth-token-id")]
        public string OauthTokenId { get; set; }

        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        [JsonPropertyName("default-branch")]
        public bool DefaultBranch { get; set; }
    }
}
