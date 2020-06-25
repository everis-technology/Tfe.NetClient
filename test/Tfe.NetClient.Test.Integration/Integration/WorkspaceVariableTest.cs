namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.WorkspaceVariables;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;
    using Xunit.Extensions.Ordering;

    /// <summary>
    /// WorkspaceVariable
    /// </summary>
    [Order(3)]
    public class WorkspaceVariable : IClassFixture<IntegrationTestFixture>
    {
        /// <summary>
        /// configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// WorkspaceVariable
        /// </summary>
        /// <param name="fixture"></param>
        public WorkspaceVariable(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        /// <summary>
        /// CreateWorkspaceVariables
        /// </summary>
        /// <returns></returns>
        [Fact, Order(1)]
        public async Task CreateWorkspaceVariables()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["teamToken"], httpClient);

            var client = new TfeClient(config);

            await CreateWorkspaceVariable("your_name", "cmendibl3", "your name", false, client);
            await CreateWorkspaceVariable("tfe_org_name", organizationName, "tfe_org_name", false, client);
            await CreateWorkspaceVariable("tfe_host", "app.terraform.io", "tfe_host", false, client);
            await CreateWorkspaceVariable("tfe_workspace_name", "test-workspace-github", "tfe_workspace_name", false, client);
            await CreateWorkspaceVariable("ARM_CLIENT_ID", configuration["ARM_CLIENT_ID"], "ARM_CLIENT_ID", true, client);
            await CreateWorkspaceVariable("ARM_CLIENT_SECRET", configuration["ARM_CLIENT_SECRET"], "ARM_CLIENT_SECRET", true, client);
            await CreateWorkspaceVariable("ARM_SUBSCRIPTION_ID", configuration["ARM_SUBSCRIPTION_ID"], "ARM_SUBSCRIPTION_ID", true, client);
            await CreateWorkspaceVariable("ARM_TENANT_ID", configuration["ARM_TENANT_ID"], "ARM_TENANT_ID", true, client);
        }

        /// <summary>
        /// CreateWorkspaceVariable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="env"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        private async Task CreateWorkspaceVariable(string key, string value, string description, bool env, TfeClient client)
        {
            var request = new WorkspaceVariablesRequest();
            request.Data.Attributes.Key = key;
            request.Data.Attributes.Value = value;
            request.Data.Attributes.Description = description;
            request.Data.Attributes.Category = !env ? "terraform" : "env";
            request.Data.Attributes.Hcl = false;
            request.Data.Attributes.Sensitive = env;

            var result = await client.WorkspaceVariable.CreateAsync(IntegrationContext.WorkspaceId, request);
            Assert.NotNull(result);
        }
    }
}