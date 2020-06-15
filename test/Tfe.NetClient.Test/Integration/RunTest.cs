namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.Runs;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;

    public class RunTest : IClassFixture<IntegrationTestFixture>
    {
        private readonly IConfiguration configuration;

        public RunTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        [Fact]
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
            request.Data.Relationships.Workspace.Data.Id = configuration["workspaceId"];

            var result = await client.Run.CreateAsync(request);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ApplyRun()
        {
            var runId = configuration["runId"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["teamToken"], httpClient);

            var client = new TfeClient(config);

            var request = new CommentRequest();
            request.Comment = "Triggered by Integration test";

            await client.Run.ApplyAsync(runId, null);
        }
    }
}