namespace Tfe.NetClient.Teams
{
    using System.Text.Json.Serialization;

    public class Relationships
    {
        [JsonPropertyName("users")]
        public UserDatum Users { get; set; }

        [JsonPropertyName("authentication-token")]
        public AuthenticationToken AuthenticationToken { get; set; }
    }

    public class ResponseDatum
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

    public class TeamsResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    public class UserDatum
    {
        [JsonPropertyName("data")]
        public object[] Data { get; set; }
    }


    public class TeamResponse
    {
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }

    public class AuthenticationToken
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class Meta
    {
    }

    public class Attributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("users-count")]
        public long UsersCount { get; set; }

        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }

        [JsonPropertyName("organization-access")]
        public ResponseOrganizationAccess OrganizationAccess { get; set; }
    }

    public class ResponseOrganizationAccess
    {
        [JsonPropertyName("manage-policies")]
        public bool ManagePolicies { get; set; }

        [JsonPropertyName("manage-workspaces")]
        public bool ManageWorkspaces { get; set; }

        [JsonPropertyName("manage-vcs-settings")]
        public bool ManageVcsSettings { get; set; }
    }

    public class Permissions
    {
        [JsonPropertyName("can-update-membership")]
        public bool CanUpdateMembership { get; set; }

        [JsonPropertyName("can-destroy")]
        public bool CanDestroy { get; set; }

        [JsonPropertyName("can-update-organization-access")]
        public bool CanUpdateOrganizationAccess { get; set; }

        [JsonPropertyName("can-update-api-token")]
        public bool CanUpdateApiToken { get; set; }

        [JsonPropertyName("can-update-visibility")]
        public bool CanUpdateVisibility { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}