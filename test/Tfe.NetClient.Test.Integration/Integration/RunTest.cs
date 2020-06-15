namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.Runs;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;
    using Xunit.Extensions.Ordering;

    [Order(4)]
    public class RunTest : IClassFixture<IntegrationTestFixture>
    {
        private readonly IConfiguration configuration;

        public RunTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        [Fact, Order(1)]
        public async Task CreateRun()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["teamToken"], httpClient);

            var client = new TfeClient(config);

            var request = new RunsRequest();
            request.Data.Attributes.IsDestroy = false;
            request.Data.Attributes.Message = "Triggered by Integration Test";
            request.Data.Relationships.Workspace.Data.Type = "workspaces";
            request.Data.Relationships.Workspace.Data.Id = IntegrationContext.WorkspaceId;

            var result = await client.Run.CreateAsync(request);
            Assert.NotNull(result);
            IntegrationContext.RunId = result.Data.Id;
        }

        [Fact, Order(2)]
        public async Task ApplyRun()
        {
            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["teamToken"], httpClient);
            var client = new TfeClient(config);

            var runId = IntegrationContext.RunId;

            var ready = false;
            while (!ready)
            {
                await Task.Delay(5000);
                var run = await client.Run.ShowAsync(runId);
                ready = run.Data.Attributes.Status == "planned";
            }

            var request = new CommentRequest();
            request.Comment = "Triggered by Integration test";

            await client.Run.ApplyAsync(runId, null);
        }
    }
}