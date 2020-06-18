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
    /// 
    /// </summary>
    public class TfeClient
    {
        HttpClient client;

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public Organization Organization { get; }

        /// <summary>
        /// 
        /// </summary>
        public SshKey SshKey { get; }

        /// <summary>
        /// 
        /// </summary>
        public Run Run { get; }

        /// <summary>
        /// 
        /// </summary>
        public Workspace Workspace { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkspaceVariable WorkspaceVariable { get; }

        /// <summary>
        /// 
        /// </summary>
        public OAuthClient OAuthClient { get; }
    }
}


