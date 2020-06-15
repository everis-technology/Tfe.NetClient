namespace Tfe.NetClient
{
    using System.Net.Http;
    using Tfe.NetClient.OAuthClients;
    using Tfe.NetClient.Organizations;
    using Tfe.NetClient.Runs;
    using Tfe.NetClient.SshKeys;
    using Tfe.NetClient.Workspaces;
    using Tfe.NetClient.WorkspaceVariables;

    public class TfeClient
    {
        HttpClient client;

        public TfeClient(TfeConfig config)
        {
            this.client = config.HttpClient;

            Organization = new Organization(client);
            SshKey = new SshKey(client);
            Run = new Run(client);
            Workspace = new Workspace(client);
            WorkspaceVariable = new WorkspaceVariable(client);
            OAuthClient = new OAuthClient(client);
        }

        public Organization Organization { get; }

        public SshKey SshKey { get; }

        public Run Run { get; }

        public Workspace Workspace { get; }

        public WorkspaceVariable WorkspaceVariable { get; }

        public OAuthClient OAuthClient { get; }
    }
}


