namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.Runs;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;
    using Xunit.Extensions.Ordering;

    /// <summary>
    /// RunTest
    /// </summary>
    [Order(5)]
    public class RunTest : IClassFixture<IntegrationTestFixture>
    {
        /// <summary>
        /// configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// RunTest
        /// </summary>
        /// <param name="fixture"></param>
        public RunTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        /// <summary>
        /// CreateRun
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// ApplyRun
        /// </summary>
        /// <returns></returns>
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