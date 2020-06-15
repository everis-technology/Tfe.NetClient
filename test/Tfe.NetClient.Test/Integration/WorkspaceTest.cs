namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.Workspaces;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;

    public class WorkspaceTest : IClassFixture<IntegrationTestFixture>
    {
        private readonly IConfiguration configuration;

        public WorkspaceTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        [Fact]
        public async Task CreateWorkspace()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = "test-workspace-1";
            request.Data.Attributes.Name = workspaceName;

            var result = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(result);
            Assert.Equal(workspaceName, result.Data.Attributes.Name);
        }

        [Fact]
        public async Task CreateWorkspaceWithVCS()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = "test-workspace-github";
            request.Data.Attributes.Name = workspaceName;
            request.Data.Attributes.VcsRepo = new RequestVcsRepo();
            request.Data.Attributes.VcsRepo.Identifier = configuration["repo"];
            request.Data.Attributes.VcsRepo.OauthTokenId = configuration["oauthTokenId"];
            request.Data.Attributes.VcsRepo.Branch = "";
            request.Data.Attributes.VcsRepo.DefaultBranch = true;

            var result = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(result);
            Assert.Equal(workspaceName, result.Data.Attributes.Name);
        }

        [Fact]
        public async Task ShowWorkspaceByName()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = "test-workspace-2";
            request.Data.Attributes.Name = workspaceName;

            var createResult = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(createResult);
            Assert.Equal(workspaceName, createResult.Data.Attributes.Name);

            var showResult = await client.Workspace.ShowAsync(organizationName, workspaceName);
            Assert.NotNull(showResult);
            Assert.Equal(workspaceName, showResult.Data.Attributes.Name);
        }

        [Fact]
        public async Task ShowWorkspaceById()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = "test-workspace-3";
            request.Data.Attributes.Name = workspaceName;

            var createResult = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(createResult);
            Assert.Equal(workspaceName, createResult.Data.Attributes.Name);

            var showResult = await client.Workspace.ShowAsync(createResult.Data.Id);
            Assert.NotNull(showResult);
            Assert.Equal(workspaceName, showResult.Data.Attributes.Name);
            Assert.Equal(createResult.Data.Id, showResult.Data.Id);
            Assert.Equal("workspaces", showResult.Data.Type);
        }
    }
}