namespace Tfe.NetClient
{
    using Xunit;
    using Tfe.NetClient.Workspaces;
    using Tfe.NetClient.TeamWorkspaces;
    using System.Threading.Tasks;
    using System.Linq;

    /// <summary>
    /// WorkspaceTest
    /// </summary>
    public class WorkspaceTest
    {
        /// <summary>
        /// Create_Workspace_Without_VCS
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Create_Workspace_Without_VCS()
        {
            var workspaceName = "workspace-1";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("Workspace/CreateWorkspaceWithoutVCS", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            request.Data.Attributes.Name = workspaceName;

            var result = await client.Workspace.CreateAsync("organizationName", request);
            Assert.NotNull(result);
            Assert.Equal(workspaceName, result.Data.Attributes.Name);
        }

        /// <summary>
        /// Create_Workspace_With_VCS
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Create_Workspace_With_VCS()
        {
            var workspaceName = "workspace-2";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("Workspace/CreateWorkspaceWithCVS", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            request.Data.Attributes.Name = workspaceName;

            var result = await client.Workspace.CreateAsync("organizationName", request);
            Assert.NotNull(result);
            Assert.Equal(workspaceName, result.Data.Attributes.Name);
            Assert.Equal("skierkowski/terraform-test-proj", result.Data.Attributes.VcsRepo.Identifier);
            Assert.Equal("ot-hmAyP66qk2AMVdbJ", result.Data.Attributes.VcsRepo.OauthTokenId);
        }

        /// <summary>
        /// Update_Workspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Update_Workspace()
        {
            var workspaceName = "workspace-2";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("Workspace/UpdateWorkspace", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            request.Data.Attributes.Name = workspaceName;

            var result = await client.Workspace.UpdateAsync("organizationName", request);
            Assert.NotNull(result);
            Assert.Equal(workspaceName, result.Data.Attributes.Name);
            Assert.Equal("skierkowski/terraform-test-proj", result.Data.Attributes.VcsRepo.Identifier);
            Assert.Equal("ot-hmAyP66qk2AMVdbJ", result.Data.Attributes.VcsRepo.OauthTokenId);
        }

        /// <summary>
        /// List_Workspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task List_Workspace()
        {
            var workspaceName = "workspace-2";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("Workspace/ListWorkspace", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var result = await client.Workspace.ListAsync("organizationName");
            Assert.NotNull(result);
            Assert.Equal(3, result.Data.Count());
            Assert.Equal(workspaceName, result.Data[0].Attributes.Name);

            Relationships relationships = result.Data[2].Relationships;

            Relationship latestRun = relationships.LatestRun;
            Assert.Equal("run-1234567890abcdef", latestRun.RelationshipData.Id);
            Assert.Equal("runs", latestRun.RelationshipData.Type);
            Assert.Equal("/api/v2/runs/run-1234567890abcdef", latestRun.Links.Related);

            Relationship currentStateVersion = relationships.CurrentStateVersion;
            Assert.Equal("sv-1234567890abcdef", currentStateVersion.RelationshipData.Id);
            Assert.Equal("state-versions", currentStateVersion.RelationshipData.Type);
            Assert.Equal("/api/v2/workspaces/ws-1234567890abcdef/current-state-version", currentStateVersion.Links.Related);

            Relationship currentConfigurationVersion = relationships.CurrentConfigurationVersion;
            Assert.Equal("cv-1234567890abcdef", currentConfigurationVersion.RelationshipData.Id);
            Assert.Equal("configuration-versions", currentConfigurationVersion.RelationshipData.Type);
            Assert.Equal("/api/v2/configuration-versions/cv-1234567890abcdef", currentConfigurationVersion.Links.Related);

            Relationship currentRun = relationships.CurrentRun;
            Assert.Equal("run-1234567890abcdef", currentRun.RelationshipData.Id);
            Assert.Equal("runs", currentRun.RelationshipData.Type);
            Assert.Equal("/api/v2/runs/run-1234567890abcdef", currentRun.Links.Related);

            Relationship agentPool = relationships.AgentPool;
            Assert.Null(agentPool.RelationshipData);
            Assert.Null(agentPool.Links);

            Relationship readme = relationships.Readme;
            Assert.Equal("12345", readme.RelationshipData.Id);
            Assert.Equal("workspace-readme", readme.RelationshipData.Type);
            Assert.Null(agentPool.Links);
        }

        /// <summary>
        /// Show_Workspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Show_Workspace()
        {
            var workspaceId = "ws-mD5bmJ8ry3uTzuHi";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("Workspace/ShowWorkspace", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var result = await client.Workspace.ShowAsync(workspaceId);
            Assert.NotNull(result);
            Assert.Equal(workspaceId, result.Data.Id);
        }

        /// <summary>
        /// Assign_SSH_Key_To_Workspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Assign_SSH_Key_To_Workspace()
        {
            var workspaceId = "ws-SihZTyXKfNXUWuUa";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("Workspace/AssignSSHKeyToWorkspace", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var request = new AssignSsshKeyRequest();
            request.Data.Attributes.Id = "sshkey-GxrePWre1Ezug7aM";

            var result = await client.Workspace.AssignSshKeyAsync(workspaceId, request);
            Assert.NotNull(result);
            Assert.Equal(workspaceId, result.Data.Id);
            Assert.Equal(request.Data.Attributes.Id, result.Data.Relationships.SshKey.Data.Id);
        }
    }
}