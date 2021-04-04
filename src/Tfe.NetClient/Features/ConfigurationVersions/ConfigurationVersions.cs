using Tfe.NetClient.TeamWorkspaces;
using Tfe.NetClient.Workspaces;

namespace Tfe.NetClient.Features.ConfigurationVersions
{
    public class ConfigurationVersionsResponse
    {
        public ConfigurationVersions Data { get; set; }
    }

    public class ConfigurationVersions
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public ConfigurationVersionsAttributes Attributes { get; set; }

        public ConfigurationVersionsRelationships Relationships { get; set; }

        public Links Links { get; set; }
    }

    public class ConfigurationVersionsAttributes
    {
        public bool AutoQueueRuns { get; set; }

        public object Error { get; set; }

        public object ErrorMessage { get; set; }

        public string Source { get; set; }

        public string Status { get; set; }

        public StatusTimestamps StatusTimestamps { get; set; }

        public string[] ChangedFiles { get; set; }
    }

    public class StatusTimestamps
    {
    }

    public class ConfigurationVersionsRelationships
    {
        public Relationship IngressAttributes { get; set; }
    }
}
