namespace Tfe.NetClient.StateVersions
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// StateVersionsResponse
    /// </summary>
    public class StateVersionsResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Datum[] Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public StateVersionResponseLinks Links { get; set; }

        /// <summary>
        /// Meta
        /// </summary>
        /// <value></value>
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    /// <summary>
    /// StateVersionResponse
    /// </summary>
    public class StateVersionResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Datum Data { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public StateVersionResponseLinks Links { get; set; }

        /// <summary>
        /// Meta
        /// </summary>
        /// <value></value>
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    /// <summary>
    /// Datum
    /// </summary>
    public class Datum
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
        public AttributesResponse Attributes { get; set; }

        /// <summary>
        /// Relationships
        /// </summary>
        /// <value></value>
        [JsonPropertyName("relationships")]
        public RelationshipsResponse Relationships { get; set; }

        /// <summary>
        /// Links
        /// </summary>
        /// <value></value>
        [JsonPropertyName("links")]
        public DatumLinks Links { get; set; }
    }

    /// <summary>
    /// AttributesResponse
    /// </summary>
    public class AttributesResponse
    {
        /// <summary>
        /// VcsCommitSha
        /// </summary>
        /// <value></value>
        [JsonPropertyName("vcs-commit-sha")]
        public object VcsCommitSha { get; set; }

        /// <summary>
        /// VcsCommitUrl
        /// </summary>
        /// <value></value>
        [JsonPropertyName("vcs-commit-url")]
        public object VcsCommitUrl { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        /// <value></value>
        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// HostedStateDownloadUrl
        /// </summary>
        /// <value></value>
        [JsonPropertyName("hosted-state-download-url")]
        public Uri HostedStateDownloadUrl { get; set; }

        /// <summary>
        /// Serial
        /// </summary>
        /// <value></value>
        [JsonPropertyName("serial")]
        public long Serial { get; set; }
    }

    /// <summary>
    /// DatumLinks
    /// </summary>
    public class DatumLinks
    {
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    /// <summary>
    /// RelationshipsResponse
    /// </summary>
    public class RelationshipsResponse
    {
        /// <summary>
        /// Run
        /// </summary>
        /// <value></value>
        [JsonPropertyName("run")]
        public StateRun Run { get; set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("created-by")]
        public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Outputs
        /// </summary>
        /// <value></value>
        [JsonPropertyName("outputs")]
        public Outputs Outputs { get; set; }
    }

    /// <summary>
    /// CreatedBy
    /// </summary>
    public class CreatedBy
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
        public CreatedByLinks Links { get; set; }
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
    /// CreatedByLinks
    /// </summary>
    public class CreatedByLinks
    {
        /// <summary>
        /// Related
        /// </summary>
        /// <value></value>
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    /// <summary>
    /// Outputs
    /// </summary>
    public class Outputs
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public Dat[] Data { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    /// <summary>
    /// StateVersionResponseLinks
    /// </summary>
    public class StateVersionResponseLinks
    {
        /// <summary>
        /// Self
        /// </summary>
        /// <value></value>
        [JsonPropertyName("self")]
        public Uri Self { get; set; }

        /// <summary>
        /// First
        /// </summary>
        /// <value></value>
        [JsonPropertyName("first")]
        public Uri First { get; set; }

        /// <summary>
        /// Prev
        /// </summary>
        /// <value></value>
        [JsonPropertyName("prev")]
        public object Prev { get; set; }

        /// <summary>
        /// Next
        /// </summary>
        /// <value></value>
        [JsonPropertyName("next")]
        public object Next { get; set; }

        /// <summary>
        /// Last
        /// </summary>
        /// <value></value>
        [JsonPropertyName("last")]
        public Uri Last { get; set; }
    }

    /// <summary>
    /// Meta
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Pagination
        /// </summary>
        /// <value></value>
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    /// <summary>
    /// Pagination
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// CurrentPage
        /// </summary>
        /// <value></value>
        [JsonPropertyName("current-page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// PrevPage
        /// </summary>
        /// <value></value>
        [JsonPropertyName("prev-page")]
        public object PrevPage { get; set; }

        /// <summary>
        /// NextPage
        /// </summary>
        /// <value></value>
        [JsonPropertyName("next-page")]
        public object NextPage { get; set; }

        /// <summary>
        /// TotalPages
        /// </summary>
        /// <value></value>
        [JsonPropertyName("total-pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// TotalCount
        /// </summary>
        /// <value></value>
        [JsonPropertyName("total-count")]
        public long TotalCount { get; set; }
    }
}
