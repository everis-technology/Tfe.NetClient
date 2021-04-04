namespace Tfe.NetClient.Runs
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// RunsResponse
    /// </summary>
    public class RunsResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseData[] Data { get; set; }
    }

    /// <summary>
    /// RunResponse
    /// </summary>
    public class RunResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseData Data { get; set; }
    }

    /// <summary>
    /// ResponseData
    /// </summary>
    public class ResponseData
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
        public ResponseAttributes Attributes { get; set; }

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
        public DataLinks Links { get; set; }
    }

    /// <summary>
    /// ResponseAttributes
    /// </summary>
    public class ResponseAttributes
    {
        /// <summary>
        /// Actions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("actions")]
        public Actions Actions { get; set; }

        /// <summary>
        /// CanceledAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("canceled-at")]
        public object CanceledAt { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// HasChanges
        /// </summary>
        /// <value></value>
        [JsonPropertyName("has-changes")]
        public bool HasChanges { get; set; }

        /// <summary>
        /// IsDestroy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("is-destroy")]
        public bool IsDestroy { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        /// <value></value>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// PlanOnly
        /// </summary>
        /// <value></value>
        [JsonPropertyName("plan-only")]
        public bool PlanOnly { get; set; }

        /// <summary>
        /// Source
        /// </summary>
        /// <value></value>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// StatusTimestamps
        /// </summary>
        /// <value></value>
        [JsonPropertyName("status-timestamps")]
        public StatusTimestamps StatusTimestamps { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value></value>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// TriggerReason
        /// </summary>
        /// <value></value>
        [JsonPropertyName("trigger-reason")]
        public string TriggerReason { get; set; }

        /// <summary>
        /// TargetAddrs
        /// </summary>
        /// <value></value>
        [JsonPropertyName("target-addrs")]
        public object TargetAddrs { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }
    }

    /// <summary>
    /// Actions
    /// </summary>
    public class Actions
    {
        /// <summary>
        /// IsCancelable
        /// </summary>
        /// <value></value>
        [JsonPropertyName("is-cancelable")]
        public bool IsCancelable { get; set; }

        /// <summary>
        /// IsConfirmable
        /// </summary>
        /// <value></value>
        [JsonPropertyName("is-confirmable")]
        public bool IsConfirmable { get; set; }

        /// <summary>
        /// IsDiscardable
        /// </summary>
        /// <value></value>
        [JsonPropertyName("is-discardable")]
        public bool IsDiscardable { get; set; }

        /// <summary>
        /// IsForceCancelable
        /// </summary>
        /// <value></value>
        [JsonPropertyName("is-force-cancelable")]
        public bool IsForceCancelable { get; set; }
    }

    /// <summary>
    /// Permissions
    /// </summary>
    public class Permissions
    {
        /// <summary>
        /// CanApply
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-apply")]
        public bool CanApply { get; set; }

        /// <summary>
        /// CanCancel
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-cancel")]
        public bool CanCancel { get; set; }

        /// <summary>
        /// CanComment
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-comment")]
        public bool CanComment { get; set; }

        /// <summary>
        /// CanDiscard
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-discard")]
        public bool CanDiscard { get; set; }

        /// <summary>
        /// CanForceExecute
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-force-execute")]
        public bool CanForceExecute { get; set; }

        /// <summary>
        /// CanForceCancel
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-force-cancel")]
        public bool CanForceCancel { get; set; }

        /// <summary>
        /// CanOverridePolicyCheck
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-override-policy-check")]
        public bool CanOverridePolicyCheck { get; set; }
    }

    /// <summary>
    /// StatusTimestamps
    /// </summary>
    public class StatusTimestamps
    {
        /// <summary>
        /// PlanQueueableAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("plan-queueable-at")]
        public DateTimeOffset PlanQueueableAt { get; set; }
    }

    /// <summary>
    /// DataLinks
    /// </summary>
    public class DataLinks
    {
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    /// <summary>
    /// Relationships
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// Workspace
        /// </summary>
        /// <value></value>
        [JsonPropertyName("workspace")]
        public ResponseWorkspace Workspace { get; set; }

        /// <summary>
        /// Apply
        /// </summary>
        /// <value></value>
        [JsonPropertyName("apply")]
        public ApplyResponse Apply { get; set; }

        /// <summary>
        /// ConfigurationVersion
        /// </summary>
        /// <value></value>
        [JsonPropertyName("configuration-version")]
        public ApplyResponse ConfigurationVersion { get; set; }

        /// <summary>
        /// Plan
        /// </summary>
        /// <value></value>
        [JsonPropertyName("plan")]
        public ApplyResponse Plan { get; set; }

        /// <summary>
        /// RunEvents
        /// </summary>
        /// <value></value>
        [JsonPropertyName("run-events")]
        public Comments RunEvents { get; set; }

        /// <summary>
        /// PolicyChecks
        /// </summary>
        /// <value></value>
        [JsonPropertyName("policy-checks")]
        public Comments PolicyChecks { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        /// <value></value>
        [JsonPropertyName("comments")]
        public Comments Comments { get; set; }
    }

    /// <summary>
    /// Apply
    /// </summary>
    public class ApplyResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Dat Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public ApplyLinks Links { get; set; }
    }

    /// <summary>
    /// Dat
    /// </summary>
    public class Dat
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
    /// ApplyLinks
    /// </summary>
    public class ApplyLinks
    {
        /// <summary>
        /// Related
        /// </summary>
        /// <value></value>
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    /// <summary>
    /// Comments
    /// </summary>
    public class Comments
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Dat[] Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public ApplyLinks Links { get; set; }
    }

    /// <summary>
    /// ResponseWorkspace
    /// </summary>
    public class ResponseWorkspace
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Dat Data { get; set; }
    }
}
