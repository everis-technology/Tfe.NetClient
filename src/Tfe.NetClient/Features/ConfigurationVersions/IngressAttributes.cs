using Tfe.NetClient.TeamWorkspaces;
using Tfe.NetClient.Workspaces;

namespace Tfe.NetClient.Features.ConfigurationVersions
{
    public class IngressAttributesResponse
    {
        public IngressAttributes Data { get; set; }
    }

    public class IngressAttributes
    {
        public string Id { get; set; }
        
        public string Type { get; set; }
        
        public Attributes Attributes { get; set; }
        
        public IngressAttributesRelationships Relationships { get; set; }
        
        public Links Links { get; set; }
    }

    public class Attributes
    {
        public string Branch { get; set; }

        public string CloneUrl { get; set; }

        public string CommitMessage { get; set; }

        public string CommitSha { get; set; }
        
        public string CommitUrl { get; set; }
        
        public string CompareUrl { get; set; }
        
        public string Identifier { get; set; }

        public bool IsPullRequest { get; set; }

        public bool OnDefaultBranch { get; set; }

        public object PullRequestNumber { get; set; }

        public object PullRequestUrl { get; set; }

        public object PullRequestTitle { get; set; }

        public object PullRequestBody { get; set; }

        public object Tag { get; set; }

        public string SenderUsername { get; set; }

        public string SenderAvatarUrl { get; set; }

        public string SenderHtmlUrl { get; set; }
    }

    public class IngressAttributesRelationships
    {
        public Relationship CreatedBy { get; set; }
    }
}