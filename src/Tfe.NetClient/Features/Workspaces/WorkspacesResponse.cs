namespace Tfe.NetClient.Workspaces
{
    using System;
    using System.Text.Json.Serialization;

    public class Relationships
    {
        [JsonPropertyName("organization")]
        public OrganizationDatam Organization { get; set; }

        [JsonPropertyName("ssh-key")]
        public SimpleDatam SshKey { get; set; }

        [JsonPropertyName("latest-run")]
        public SimpleDatam LatestRun { get; set; }
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

    public class WorkspacesResponse
    {
        [JsonPropertyName("data")]
        public Data[] Data { get; set; }
    }

    public class WorkspaceResponse
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }


    public class OrganizationDatam
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class SimpleDatam
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("auto-apply")]
        public bool AutoApply { get; set; }

        [JsonPropertyName("allow-destroy-plan")]
        public bool AllowDestroyPlan { get; set; }

        [JsonPropertyName("can-queue-destroy-plan")]
        public bool CanQueueDestroyPlan { get; set; }

        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("environment")]
        public string Environment { get; set; }

        [JsonPropertyName("file-triggers-enabled")]
        public bool FileTriggersEnabled { get; set; }

        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }

        [JsonPropertyName("queue-all-runs")]
        public bool QueueAllRuns { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("source-name")]
        public object SourceName { get; set; }

        [JsonPropertyName("source-url")]
        public object SourceUrl { get; set; }

        [JsonPropertyName("terraform-version")]
        public string TerraformVersion { get; set; }

        [JsonPropertyName("trigger-prefixes")]
        public object[] TriggerPrefixes { get; set; }

        [JsonPropertyName("vcs-repo")]
        public VcsRepo VcsRepo { get; set; }

        [JsonPropertyName("working-directory")]
        public object WorkingDirectory { get; set; }
    }

    public class Permissions
    {
        [JsonPropertyName("can-update")]
        public bool CanUpdate { get; set; }

        [JsonPropertyName("can-destroy")]
        public bool CanDestroy { get; set; }

        [JsonPropertyName("can-queue-destroy")]
        public bool CanQueueDestroy { get; set; }

        [JsonPropertyName("can-queue-run")]
        public bool CanQueueRun { get; set; }

        [JsonPropertyName("can-update-variable")]
        public bool CanUpdateVariable { get; set; }

        [JsonPropertyName("can-lock")]
        public bool CanLock { get; set; }

        [JsonPropertyName("can-read-settings")]
        public bool CanReadSettings { get; set; }
    }

    public class VcsRepo
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        [JsonPropertyName("oauth-token-id")]
        public string OauthTokenId { get; set; }

        [JsonPropertyName("ingress-submodules")]
        public bool IngressSubmodules { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}