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
        /// CreateWorkspaceworkspace-2
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateWorkspace()
        {
            var workspaceName = "workspace-1";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       var jsonResult = GetSampleResponse("CreateWorkspaceWithoutVCS");
                       SendResponse(jsonResult, entry);
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

        private void SendResponse(string body, TestHttpClient.Entry entry)
        {
            var response = new HttpResponseMessage
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent(
                                body, System.Text.Encoding.UTF8,
                                "application/json"),
            };

            entry.Completion.SetResult(response);
        }

        private string GetSampleResponse(string responseFile)
        {
            var file = $"ResponseSamples/{responseFile}.json";
            using (var stream = embeddedProvider.GetFileInfo(file).CreateReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}