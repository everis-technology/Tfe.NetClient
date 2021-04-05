using Tfe.NetClient.Features.ConfigurationVersions;

namespace Tfe.NetClient
{
    using System.Net.Http;
    using Tfe.NetClient.OAuthClients;
    using Tfe.NetClient.Organizations;
    using Tfe.NetClient.Plans;
    using Tfe.NetClient.Runs;
    using Tfe.NetClient.SshKeys;
    using Tfe.NetClient.Workspaces;
    using Tfe.NetClient.WorkspaceVariables;
    using Tfe.NetClient.Applies;
    using Tfe.NetClient.StateVersions;
    using Tfe.NetClient.StateVersionOutputs;
    using Tfe.NetClient.TeamWorkspaces;

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

            Apply = new Apply(client);
            Organization = new Organization(client);
            SshKey = new SshKey(client);
            Run = new Run(client);
            Workspace = new Workspace(client);
            WorkspaceVariable = new WorkspaceVariable(client);
            OAuthClient = new OAuthClient(client);
            StateVersion = new StateVersion(client);
            StateVersionOutput = new StateVersionOutput(client);
            TeamWorkspace = new TeamWorkspace(client);
        }

        /// <summary>
        /// Plan
        /// </summary>
        /// <value></value>
        public Plan Plan { get; }


        /// <summary>
        /// Applies
        /// </summary>
        /// <value></value>
        public Apply Apply { get; }

        /// <summary>
        /// Applies
        /// </summary>
        /// <value></value>
        public ConfigurationVersion ConfigurationVersion { get; }

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

        /// <summary>
        /// State Version
        /// </summary>
        /// <value></value>
        public StateVersion StateVersion { get; }

        /// <summary>
        /// State Version Output
        /// </summary>
        /// <value></value>
        public StateVersionOutput StateVersionOutput { get; }

        /// <summary>
        /// TeamWorkspace
        /// </summary>
        /// <value></value>
        public TeamWorkspace TeamWorkspace { get; }
    }
}


