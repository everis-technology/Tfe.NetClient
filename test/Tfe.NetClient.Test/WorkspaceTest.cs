namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.Workspaces;
    using System.Threading.Tasks;
    using Microsoft.Extensions.FileProviders;
    using System.Reflection;
    using System.IO;

    /// <summary>
    /// WorkspaceTest
    /// </summary>
    public class WorkspaceTest
    {
        EmbeddedFileProvider embeddedProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());

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
                       SendResponse("CreateWorkspaceWithoutVCS", entry);
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
                       SendResponse("CreateWorkspaceWithCVS", entry);
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

        private void SendResponse(string responseFile, TestHttpClient.Entry entry)
        {
            var file = $"ResponseSamples/{responseFile}.json";
            using (var stream = embeddedProvider.GetFileInfo(file).CreateReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    var body = reader.ReadToEnd();

                    var response = new HttpResponseMessage
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Content = new StringContent(
                               body, System.Text.Encoding.UTF8,
                               "application/json"),
                    };

                    entry.Completion.SetResult(response);
                }
            }
        }
    }
}