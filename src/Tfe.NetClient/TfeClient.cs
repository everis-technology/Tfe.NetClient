namespace Tfe.NetClient
{
    using System.Net.Http;
    using Tfe.NetClient.OAuthClients;
    using Tfe.NetClient.Organizations;
    using Tfe.NetClient.Runs;
    using Tfe.NetClient.SshKeys;
    using Tfe.NetClient.Workspaces;
    using Tfe.NetClient.WorkspaceVariables;

    /// <summary>
    /// TfeClient
    /// </summary>
    public class TfeClient
    {   
        /// <summary>
        /// client
        /// </summary>
        HttpClient client;

        /// <summary>
        /// TfeClient
        /// </summary>
        /// <param name="config"></param>
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

        /// <summary>
        /// Organization
        /// </summary>
        /// <value></value>
        public Organization Organization { get; }

        /// <summary>
        /// SshKey
        /// </summary>
        /// <value></value>
        public SshKey SshKey { get; }

        /// <summary>
        /// Run
        /// </summary>
        /// <value></value>
        public Run Run { get; }

        /// <summary>
        /// Workspace
        /// </summary>
        /// <value></value>
        public Workspace Workspace { get; }

        /// <summary>
        /// WorkspaceVariable
        /// </summary>
        /// <value></value>
        public WorkspaceVariable WorkspaceVariable { get; }

        /// <summary>
        /// OAuthClient
        /// </summary>
        /// <value></value>
        public OAuthClient OAuthClient { get; }
    }
}


