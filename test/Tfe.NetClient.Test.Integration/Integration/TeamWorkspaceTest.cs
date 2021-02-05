namespace Tfe.NetClient.Test.Integration.Integration
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Tfe.NetClient.TeamWorkspaces;
    using Tfe.NetClient.Workspaces;
    using Xunit;
    using Xunit.Extensions.Ordering;

    /// <summary>
    /// TeamWorkspaceTest
    /// </summary>
    [Order(6)]
    public class TeamWorkspaceTest : IClassFixture<IntegrationTestFixture>
    {
        /// <summary>
        /// configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// TeamWorkspaceTest
        /// </summary>
        /// <param name="fixture"></param>
        public TeamWorkspaceTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        /// <summary>
        /// SetupTestWorkspace
        /// </summary>
        /// <returns></returns>
        private async Task<(TfeClient, WorkspaceResponse)> SetupTestWorkspace()
        {
            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["organizationToken"], httpClient);
            var client = new TfeClient(config);

            var organizationName = configuration["organizationName"];

            var workspaceRequest = new WorkspacesRequest();
            var workspaceName = $"test-{Guid.NewGuid().ToString()}";
            workspaceRequest.Data.Attributes.Name = workspaceName;

            var workspace = await client.Workspace.CreateAsync(organizationName, workspaceRequest);

            return (client, workspace);
        }

        /// <summary>
        /// AssignListAndShowTeamAccessToWorkspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task AssignListAndShowTeamAccessToWorkspace()
        {
            var teamId = configuration["teamId"];

            var (client, workspace) = await SetupTestWorkspace();

            var permissions = new TeamWorkspaceCustomPermissions();
            permissions.Runs = RunPermissions.Plan;
            permissions.Variables = VariablesPermissions.Write;

            var request = new Request(teamId, workspace.Data.Id, permissions);

            var result = await client.TeamWorkspace.CreateAsync(request);
            Assert.NotNull(result);
            Assert.Equal(workspace.Data.Id, result.Data.Relationships.Workspace.RelationshipData.Id);
            Assert.Equal(teamId, result.Data.Relationships.Team.RelationshipData.Id);

            var listResult = await client.TeamWorkspace.ListAsync(workspace.Data.Id);
            Assert.NotNull(listResult);
            Assert.Equal(workspace.Data.Id, listResult.Data[0].Relationships.Workspace.RelationshipData.Id);
            Assert.Equal(teamId, listResult.Data[0].Relationships.Team.RelationshipData.Id);

            var showResult = await client.TeamWorkspace.ShowAsync(result.Data.Id);
            Assert.NotNull(showResult);
            Assert.Equal(workspace.Data.Id, showResult.Data.Relationships.Workspace.RelationshipData.Id);
            Assert.Equal(teamId, showResult.Data.Relationships.Team.RelationshipData.Id);
        }

        /// <summary>
        /// UpdateTeamAccessToWorkspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task UpdateTeamAccessToWorkspace()
        {
            var teamId = configuration["teamId"];

            var (client, workspace) = await SetupTestWorkspace();

            var permissions = new TeamWorkspacePermissions();
            permissions.Access = AccessPermissions.Admin;

            var request = new Request(teamId, workspace.Data.Id, permissions);
            var create = await client.TeamWorkspace.CreateAsync(request);


            var newPermissions = new TeamWorkspaceCustomPermissions();
            newPermissions.Runs = RunPermissions.Plan;
            newPermissions.Variables = VariablesPermissions.Write;
            newPermissions.WorkspaceLocking = true;

            var updateRequest = new UpdateRequest();
            updateRequest.Data.Attributes = newPermissions;

            var result = await client.TeamWorkspace.UpdateAsync(create.Data.Id, updateRequest);
            Assert.NotNull(result);
            Assert.Equal(workspace.Data.Id, result.Data.Relationships.Workspace.RelationshipData.Id);
            Assert.Equal(teamId, result.Data.Relationships.Team.RelationshipData.Id);
        }

    }
}
