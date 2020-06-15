namespace Tfe.NetClient.Runs
{
    using System;
    using System.Text.Json.Serialization;

    public class RunsResponse
    {
        [JsonPropertyName("data")]
        public ResponseData[] Data { get; set; }
    }

    public class RunResponse
    {
        [JsonPropertyName("data")]
        public ResponseData Data { get; set; }
    }

    public class ResponseData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public ResponseAttributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public DataLinks Links { get; set; }
    }

    public class ResponseAttributes
    {
        [JsonPropertyName("actions")]
        public Actions Actions { get; set; }

        [JsonPropertyName("canceled-at")]
        public object CanceledAt { get; set; }

        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("has-changes")]
        public bool HasChanges { get; set; }

        [JsonPropertyName("is-destroy")]
        public bool IsDestroy { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("plan-only")]
        public bool PlanOnly { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("status-timestamps")]
        public StatusTimestamps StatusTimestamps { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("trigger-reason")]
        public string TriggerReason { get; set; }

        [JsonPropertyName("target-addrs")]
        public object TargetAddrs { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }
    }

    public class Actions
    {
        [JsonPropertyName("is-cancelable")]
        public bool IsCancelable { get; set; }

        [JsonPropertyName("is-confirmable")]
        public bool IsConfirmable { get; set; }

        [JsonPropertyName("is-discardable")]
        public bool IsDiscardable { get; set; }

        [JsonPropertyName("is-force-cancelable")]
        public bool IsForceCancelable { get; set; }
    }

    public class Permissions
    {
        [JsonPropertyName("can-apply")]
        public bool CanApply { get; set; }

        [JsonPropertyName("can-cancel")]
        public bool CanCancel { get; set; }

        [JsonPropertyName("can-comment")]
        public bool CanComment { get; set; }

        [JsonPropertyName("can-discard")]
        public bool CanDiscard { get; set; }

        [JsonPropertyName("can-force-execute")]
        public bool CanForceExecute { get; set; }

        [JsonPropertyName("can-force-cancel")]
        public bool CanForceCancel { get; set; }

        [JsonPropertyName("can-override-policy-check")]
        public bool CanOverridePolicyCheck { get; set; }
    }

    public class StatusTimestamps
    {
        [JsonPropertyName("plan-queueable-at")]
        public DateTimeOffset PlanQueueableAt { get; set; }
    }

    public class DataLinks
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("workspace")]
        public ResponseWorkspace Workspace { get; set; }

        [JsonPropertyName("apply")]
        public Apply Apply { get; set; }

        [JsonPropertyName("configuration-version")]
        public Apply ConfigurationVersion { get; set; }

        [JsonPropertyName("plan")]
        public Apply Plan { get; set; }

        [JsonPropertyName("run-events")]
        public Comments RunEvents { get; set; }

        [JsonPropertyName("policy-checks")]
        public Comments PolicyChecks { get; set; }

        [JsonPropertyName("comments")]
        public Comments Comments { get; set; }
    }

    public class Apply
    {
        [JsonPropertyName("data")]
        public Dat Data { get; set; }

        [JsonPropertyName("links")]
        public ApplyLinks Links { get; set; }
    }

    public class Dat
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class ApplyLinks
    {
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class Comments
    {
        [JsonPropertyName("data")]
        public Dat[] Data { get; set; }

        [JsonPropertyName("links")]
        public ApplyLinks Links { get; set; }
    }

    public class ResponseWorkspace
    {
        [JsonPropertyName("data")]
        public Dat Data { get; set; }
    }
}
