namespace Tfe.NetClient.Workspaces
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// WorkspacesRequest
    /// </summary>
    public class WorkspacesRequest
    {   
        /// <summary>
        /// WorkspacesRequest
        /// </summary>
        public WorkspacesRequest()
        {
            this.Data = new RequestData();
        }
        
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public RequestData Data { get; }
    }

    /// <summary>
    /// RequestData
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// RequestData
        /// </summary>
        public RequestData()
        {
            this.Attributes = new RequestAttributes();
        }

        /// <summary>
        /// Attributes
        /// </summary>
        /// <value></value>
        [JsonPropertyName("attributes")]
        public RequestAttributes Attributes { get; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type => "workspaces";
    }

    /// <summary>
    /// RequestAttributes
    /// </summary>
    public class RequestAttributes
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <value></value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// TerraformVersion
        /// </summary>
        /// <value></value>
        [JsonPropertyName("terraform_version")]
        public string TerraformVersion { get; set; }

        /// <summary>
        /// TriggerPrefixes
        /// </summary>
        /// <value></value>
        [JsonPropertyName("trigger-prefixes")]
        public string[] TriggerPrefixes { get; set; }

        /// <summary>
        /// WorkingDirectory
        /// </summary>
        /// <value></value>
        [JsonPropertyName("working-directory")]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// VcsRepo
        /// </summary>
        /// <value></value>
        [JsonPropertyName("vcs-repo")]
        public RequestVcsRepo VcsRepo { get; set; }
    }

    /// <summary>
    /// RequestVcsRepo
    /// </summary>
    public class RequestVcsRepo
    {
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value></value>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// OauthTokenId
        /// </summary>
        /// <value></value>
        [JsonPropertyName("oauth-token-id")]
        public string OauthTokenId { get; set; }

        /// <summary>
        /// Branch
        /// </summary>
        /// <value></value>
        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// DefaultBranch
        /// </summary>
        /// <value></value>
        [JsonPropertyName("default-branch")]
        public bool DefaultBranch { get; set; }
    }
}
