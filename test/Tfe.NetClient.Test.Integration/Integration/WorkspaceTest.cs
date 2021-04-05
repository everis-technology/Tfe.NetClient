namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.Workspaces;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;
    using Xunit.Extensions.Ordering;
    using System;

    /// <summary>
    /// WorkspaceTest
    /// </summary>
    [Order(3)]
    public class WorkspaceTest : IClassFixture<IntegrationTestFixture>
    {
        /// <summary>
        /// configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// WorkspaceTest
        /// </summary>
        /// <param name="fixture"></param>
        public WorkspaceTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        /// <summary>
        /// CreateWorkspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateWorkspace()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = $"test-{Guid.NewGuid().ToString()}";
            request.Data.Attributes.Name = workspaceName;

            var result = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(result);
            Assert.Equal(workspaceName, result.Data.Attributes.Name);
        }

        /// <summary>
        /// CreateWorkspaceWithVCS
        /// </summary>
        /// <returns></returns>
        [Fact, Order(1)]
        public async Task CreateWorkspaceWithVCS()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = $"test-{Guid.NewGuid().ToString()}";
            request.Data.Attributes.Name = workspaceName;
            request.Data.Attributes.VcsRepo = new RequestVcsRepo();
            request.Data.Attributes.VcsRepo.Identifier = configuration["repo"];
            request.Data.Attributes.VcsRepo.OauthTokenId = IntegrationContext.OAuthTokenId;
            request.Data.Attributes.VcsRepo.Branch = "";
            request.Data.Attributes.VcsRepo.DefaultBranch = true;

            var result = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(result);
            Assert.Equal(workspaceName, result.Data.Attributes.Name);
            IntegrationContext.WorkspaceId = result.Data.Id;
        }

        /// <summary>
        /// AssignSshKeyToWorkSpace
        /// </summary>
        /// <returns></returns>
        [Fact, Order(2)]
        public async Task AssignSshKeyToWorkSpace()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["teamToken"], httpClient);

            var client = new TfeClient(config);

            var request = new AssignSsshKeyRequest();
            request.Data.Attributes.Id = IntegrationContext.SshKeyId;

            var result = await client.Workspace.AssignSshKeyAsync(IntegrationContext.WorkspaceId, request);
            Assert.NotNull(result);
            Assert.Equal(IntegrationContext.SshKeyId, result.Data.Relationships.SshKey.Data.Id);
        }

        /// <summary>
        /// GetWorkspaceByName
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetWorkspaceByName()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = $"test-{Guid.NewGuid().ToString()}";
            request.Data.Attributes.Name = workspaceName;

            var createResult = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(createResult);
            Assert.Equal(workspaceName, createResult.Data.Attributes.Name);

            var showResult = await client.Workspace.GetAsync(organizationName, workspaceName);
            Assert.NotNull(showResult);
            Assert.Equal(workspaceName, showResult.Data.Attributes.Name);
        }

        /// <summary>
        /// GetWorkspaceById
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetWorkspaceById()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);

            var client = new TfeClient(config);

            var request = new WorkspacesRequest();
            var workspaceName = $"test-{Guid.NewGuid().ToString()}";
            request.Data.Attributes.Name = workspaceName;

            var createResult = await client.Workspace.CreateAsync(organizationName, request);
            Assert.NotNull(createResult);
            Assert.Equal(workspaceName, createResult.Data.Attributes.Name);

            var showResult = await client.Workspace.GetAsync(createResult.Data.Id);
            Assert.NotNull(showResult);
            Assert.Equal(workspaceName, showResult.Data.Attributes.Name);
            Assert.Equal(createResult.Data.Id, showResult.Data.Id);
            Assert.Equal("workspaces", showResult.Data.Type);
        }
    }
}