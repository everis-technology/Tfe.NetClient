namespace Tfe.NetClient.TeamWorkspaces
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// UpdateRequest
    /// </summary>
    /// <value></value>
    public partial class UpdateRequest
    {
        /// <summary>
        /// TeamWorkspacesRequestData
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public UpdateRequestData Data { get; set; }

        /// <summary>
        /// UpdateRequest
        /// </summary>
        /// <value></value>
        public UpdateRequest()
        {
            this.Data = new UpdateRequestData();
        }
    }

    /// <summary>
    /// Request
    /// </summary>
    /// <value></value>
    public partial class Request
    {
        /// <summary>
        /// TeamWorkspacesRequestData
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public RequestData Data { get; set; }

        /// <summary>
        /// Request
        /// </summary>
        /// <value></value>
        public Request()
        {
            this.Data = new RequestData();
        }

        /// <summary>
        /// Request
        /// </summary>
        /// <value></value>
        public Request(string teamId, string workspaceId, dynamic permissions)
        {
            if (permissions is TeamWorkspacePermissions || permissions is TeamWorkspaceCustomPermissions)
            {
                throw new ArgumentException();
            }

            this.Data = new RequestData();
            this.Data.Relationships.Team.RelationshipData.Id = teamId;
            this.Data.Relationships.Workspace.RelationshipData.Id = workspaceId;
            this.Data.Attributes = permissions;
        }
    }

    /// <summary>
    /// UpdateRequestData
    /// </summary>
    /// <value></value>
    public partial class UpdateRequestData
    {
        /// <summary>
        /// Attributes
        /// </summary>
        /// <value></value>
        [JsonPropertyName("attributes")]
        public dynamic Attributes { get; set; }
    }

    /// <summary>
    /// RequestData
    /// </summary>
    /// <value></value>
    public partial class RequestData : UpdateRequestData
    {
        /// <summary>
        /// TeamWorkspacesRequestData
        /// </summary>
        /// <value></value>
        public RequestData()
        {
            this.Relationships = new RequestRelationships();
        }

        /// <summary>
        /// Relationships
        /// </summary>
        /// <value></value>
        [JsonPropertyName("relationships")]
        public RequestRelationships Relationships { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value></value>
        [JsonPropertyName("type")]
        public string Type { get; } = "team-workspaces";
    }

    /// <summary>
    /// RequestRelationships
    /// </summary>
    public partial class RequestRelationships
    {
        /// <summary>
        /// RequestRelationships
        /// </summary>
        public RequestRelationships()
        {
            this.Workspace = new RequestRelationship();
            this.Team = new RequestRelationship();
            this.Workspace.RelationshipData.Type = "workspaces";
            this.Team.RelationshipData.Type = "teams";
        }

        /// <summary>
        /// Workspace
        /// </summary>
        /// <value></value>
        [JsonPropertyName("workspace")]
        public RequestRelationship Workspace { get; set; }

        /// <summary>
        /// Team
        /// </summary>
        /// <value></value>
        [JsonPropertyName("team")]
        public RequestRelationship Team { get; set; }
    }

    /// <summary>
    /// RequestRelationship
    /// </summary>
    public partial class RequestRelationship
    {
        public RequestRelationship()
        {
            this.RelationshipData = new RelationshipData();
        }

        /// <summary>
        /// Data
        /// </summary>
        /// <value></value>
        [JsonPropertyName("data")]
        public RelationshipData RelationshipData { get; set; }
    }
}
