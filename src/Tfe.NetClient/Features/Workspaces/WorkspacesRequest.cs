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
        public string Type { get; } = "workspaces";
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
        /// AgentPoolId
        /// </summary>
        /// <value></value>
        [JsonPropertyName("agent-pool-id")]
        public string AgentPoolId { get; set; }

        /// <summary>
        /// AllowDestroyPlan
        /// </summary>
        /// <value></value>
        [JsonPropertyName("allow-destroy-plan")]
        public bool? AllowDestroyPlan { get; set; }

        /// <summary>
        /// AutoApply
        /// </summary>
        /// <value></value>
        [JsonPropertyName("auto-apply")]
        public bool? AutoApply { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value></value>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// ExecutionMode
        /// </summary>
        /// <value></value>
        [JsonPropertyName("execution-mode")]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// FileTriggersEnabled
        /// </summary>
        /// <value></value>
        [JsonPropertyName("file-triggers-enabled")]
        public bool? FileTriggersEnabled { get; set; }

        /// <summary>
        /// QueueAllRuns
        /// </summary>
        /// <value></value>
        [JsonPropertyName("queue-all-runs")]
        public bool? QueueAllRuns { get; set; }

        /// <summary>
        /// SpeculativeEnabled
        /// </summary>
        /// <value></value>
        [JsonPropertyName("speculative-enabled")]
        public bool? SpeculativeEnabled { get; set; }

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
