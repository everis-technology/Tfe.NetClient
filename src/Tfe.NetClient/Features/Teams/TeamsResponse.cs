namespace Tfe.NetClient.Teams
{
    using System.Text.Json.Serialization;
    
    /// <summary>
    /// Relationships
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// Users
        /// </summary>
        /// <value></value>
        [JsonPropertyName("users")]
        public UserDatum Users { get; set; }

        /// <summary>
        /// AuthenticationToken
        /// </summary>
        /// <value></value>
        [JsonPropertyName("authentication-token")]
        public AuthenticationToken AuthenticationToken { get; set; }
    }

    /// <summary>
    /// ResponseDatum
    /// </summary>
    public class ResponseDatum
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
    /// TeamsResponse
    /// </summary>
    public class TeamsResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseDatum[] Data { get; set; }
    }

    /// <summary>
    /// Data
    /// </summary>
    public class UserDatum
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public object[] Data { get; set; }
    }

    /// <summary>
    /// TeamResponse
    /// </summary>
    public class TeamResponse
    {
        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public ResponseDatum Data { get; set; }
    }

    /// <summary>
    /// AuthenticationToken
    /// </summary>
    public class AuthenticationToken
    {
        /// <summary>
        /// Meta
        /// </summary>
        /// <value></value>
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    /// <summary>
    /// Meta
    /// </summary>
    public class Meta
    {
    }

    /// <summary>
    /// Attributes
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <value></value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// UsersCount
        /// </summary>
        /// <value></value>
        [JsonPropertyName("users-count")]
        public long UsersCount { get; set; }

        /// <summary>
        /// Visibility
        /// </summary>
        /// <value></value>
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        /// <value></value>
        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }

        /// <summary>
        /// OrganizationAccess
        /// </summary>
        /// <value></value>
        [JsonPropertyName("organization-access")]
        public ResponseOrganizationAccess OrganizationAccess { get; set; }
    }

    /// <summary>
    /// ResponseOrganizationAccess
    /// </summary>
    public class ResponseOrganizationAccess
    {
        /// <summary>
        /// ManagePolicies
        /// </summary>
        /// <value></value>
        [JsonPropertyName("manage-policies")]
        public bool ManagePolicies { get; set; }

        /// <summary>
        /// ManageWorkspaces
        /// </summary>
        /// <value></value>
        [JsonPropertyName("manage-workspaces")]
        public bool ManageWorkspaces { get; set; }

        /// <summary>
        /// ManageVcsSettings
        /// </summary>
        /// <value></value>
        [JsonPropertyName("manage-vcs-settings")]
        public bool ManageVcsSettings { get; set; }
    }

    /// <summary>
    /// Permissions
    /// </summary>
    public class Permissions
    {   
        /// <summary>
        /// CanUpdateMembership
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-membership")]
        public bool CanUpdateMembership { get; set; }

        /// <summary>
        /// CanDestroy
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-destroy")]
        public bool CanDestroy { get; set; }

        /// <summary>
        /// CanUpdateOrganizationAccess
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-organization-access")]
        public bool CanUpdateOrganizationAccess { get; set; }

        /// <summary>
        /// CanUpdateApiToken
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-api-token")]
        public bool CanUpdateApiToken { get; set; }

        /// <summary>
        /// CanUpdateVisibility
        /// </summary>
        /// <value></value>
        [JsonPropertyName("can-update-visibility")]
        public bool CanUpdateVisibility { get; set; }
    }

    /// <summary>
    /// Links
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