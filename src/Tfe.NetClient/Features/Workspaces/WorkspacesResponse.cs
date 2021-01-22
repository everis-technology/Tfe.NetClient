namespace Tfe.NetClient.Workspaces
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Relationships
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// Organization
        /// </summary>
        /// <value></value>
        [JsonPropertyName("organization")]
        public OrganizationDatam Organization { get; set; }

        /// <summary>
        /// SshKey
        /// </summary>
        /// <value></value>
        [JsonPropertyName("ssh-key")]
        public SimpleDatam SshKey { get; set; }

        /// <summary>
        /// LatestRun
        /// </summary>
        /// <value></value>
        [JsonPropertyName("latest-run")]
        public SimpleDatam LatestRun { get; set; }

        /// <summary>
        /// CurrentStateVersion
        /// </summary>
        /// <value></value>
        [JsonPropertyName("current-state-version")]
        public SimpleDatam CurrentStateVersion { get; set; }
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
    /// WorkspacesResponse
    /// </summary>
    public class WorkspacesResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Data[] Data { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class WorkspaceResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    /// <summary>
    /// OrganizationDatam
    /// </summary>
    public class OrganizationDatam
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

    /// <summary>
    /// SimpleDatam
    /// </summary>
    public class SimpleDatam
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public OrganizationDatam Data { get; set; }
    }

    /// <summary>
    /// Attributes
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// AutoApply
        /// </summary>
        /// <value></value>
        [JsonPropertyName("auto-apply")]
        public bool AutoApply { get; set; }

        /// <summary>
        /// AllowDestroyPlan
        /// </summary>
        /// <value></value>
        [JsonPropertyName("allow-destroy-plan")]
        public bool AllowDestroyPlan { get; set; }

        /// <summary>
        /// CanQueueDestroyPlan
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-queue-destroy-plan")]
        public bool CanQueueDestroyPlan { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value></value>
        [JsonPropertyName("description")]
        public object Description { get; set; }

        /// <summary>
        /// Environment
        /// </summary>
        /// <value></value>
        [JsonPropertyName("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// FileTriggersEnabled
        /// </summary>
        /// <value></value>
        [JsonPropertyName("file-triggers-enabled")]
        public bool FileTriggersEnabled { get; set; }

        /// <summary>
        /// Locked
        /// </summary>
        /// <value></value>
        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value></value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }

        /// <summary>
        /// QueueAllRuns
        /// </summary>
        /// <value></value>
        [JsonPropertyName("queue-all-runs")]
        public bool QueueAllRuns { get; set; }

        /// <summary>
        /// Source
        /// </summary>
        /// <value></value>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// SourceName
        /// </summary>
        /// <value></value>
        [JsonPropertyName("source-name")]
        public object SourceName { get; set; }

        /// <summary>
        /// SourceUrl
        /// </summary>
        /// <value></value>
        [JsonPropertyName("source-url")]
        public object SourceUrl { get; set; }

        /// <summary>
        /// TerraformVersion
        /// </summary>
        /// <value></value>
        [JsonPropertyName("terraform-version")]
        public string TerraformVersion { get; set; }

        /// <summary>
        /// TriggerPrefixes
        /// </summary>
        /// <value></value>
        [JsonPropertyName("trigger-prefixes")]
        public object[] TriggerPrefixes { get; set; }

        /// <summary>
        /// VcsRepo
        /// </summary>
        /// <value></value>
        [JsonPropertyName("vcs-repo")]
        public VcsRepo VcsRepo { get; set; }

        /// <summary>
        /// WorkingDirectory
        /// </summary>
        /// <value></value>
        [JsonPropertyName("working-directory")]
        public object WorkingDirectory { get; set; }
    }

    /// <summary>
    /// Permissions
    /// </summary>
    public class Permissions
    {
        /// <summary>
        /// CanUpdate
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update")]
        public bool CanUpdate { get; set; }

        /// <summary>
        /// CanDestroy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-destroy")]
        public bool CanDestroy { get; set; }

        /// <summary>
        /// CanQueueDestroy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-queue-destroy")]
        public bool CanQueueDestroy { get; set; }

        /// <summary>
        /// CanQueueRun
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-queue-run")]
        public bool CanQueueRun { get; set; }

        /// <summary>
        /// CanUpdateVariable
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-variable")]
        public bool CanUpdateVariable { get; set; }

        /// <summary>
        /// CanLock
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-lock")]
        public bool CanLock { get; set; }

        /// <summary>
        /// CanReadSettings
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-read-settings")]
        public bool CanReadSettings { get; set; }
    }

    /// <summary>
    /// VcsRepo
    /// </summary>
    public class VcsRepo
    {
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value></value>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Branch
        /// </summary>
        /// <value></value>
        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// OauthTokenId
        /// </summary>
        /// <value></value>
        [JsonPropertyName("oauth-token-id")]
        public string OauthTokenId { get; set; }

        /// <summary>
        /// IngressSubmodules
        /// </summary>
        /// <value></value>
        [JsonPropertyName("ingress-submodules")]
        public bool IngressSubmodules { get; set; }
    }


    /// <summary>
    /// Self
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
}