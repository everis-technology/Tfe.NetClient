namespace Tfe.NetClient.StateVersions
{
    using System;
    using System.Text.Json.Serialization;

    public class StateVersionsResponse
    {
        [JsonPropertyName("data")]
        public Datum[] Data { get; set; }

        [JsonPropertyName("links")]
        public StateVersionResponseLinks Links { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class StateVersionResponse
    {
        [JsonPropertyName("data")]
        public Datum Data { get; set; }

        [JsonPropertyName("links")]
        public StateVersionResponseLinks Links { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class Datum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public AttributesResponse Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public RelationshipsResponse Relationships { get; set; }

        [JsonPropertyName("links")]
        public DatumLinks Links { get; set; }
    }

    public class AttributesResponse
    {
        [JsonPropertyName("vcs-commit-sha")]
        public object VcsCommitSha { get; set; }

        [JsonPropertyName("vcs-commit-url")]
        public object VcsCommitUrl { get; set; }

        [JsonPropertyName("created-at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("hosted-state-download-url")]
        public Uri HostedStateDownloadUrl { get; set; }

        [JsonPropertyName("serial")]
        public long Serial { get; set; }
    }

    public class DatumLinks
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    public class RelationshipsResponse
    {
        [JsonPropertyName("run")]
        public StateRun Run { get; set; }

        [JsonPropertyName("created-by")]
        public CreatedBy CreatedBy { get; set; }

        [JsonPropertyName("outputs")]
        public Outputs Outputs { get; set; }
    }

    public class CreatedBy
    {
        [JsonPropertyName("data")]
        public Dat Data { get; set; }

        [JsonPropertyName("links")]
        public CreatedByLinks Links { get; set; }
    }

    public class Dat
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class CreatedByLinks
    {
        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class Outputs
    {
        [JsonPropertyName("data")]
        public Dat[] Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class StateVersionResponseLinks
    {
        [JsonPropertyName("self")]
        public Uri Self { get; set; }

        [JsonPropertyName("first")]
        public Uri First { get; set; }

        [JsonPropertyName("prev")]
        public object Prev { get; set; }

        [JsonPropertyName("next")]
        public object Next { get; set; }

        [JsonPropertyName("last")]
        public Uri Last { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Pagination
    {
        [JsonPropertyName("current-page")]
        public long CurrentPage { get; set; }

        [JsonPropertyName("prev-page")]
        public object PrevPage { get; set; }

        [JsonPropertyName("next-page")]
        public object NextPage { get; set; }

        [JsonPropertyName("total-pages")]
        public long TotalPages { get; set; }

        [JsonPropertyName("total-count")]
        public long TotalCount { get; set; }
    }
}
