namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Tfe.NetClient.Workspaces;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// WorkspaceTest
    /// </summary>
    public class WorkspaceTest
    {
        /// <summary>
        /// CreateWorkspaceworkspace-2
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateWorkspace()
        {
            var workspaceName = "workspace-2";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       var jsonResult = @"{
    ""data"": {
        ""attributes"": {
            ""name"": ""workspace-2"",
            ""terraform_version"": ""0.11.1"",
            ""working-directory"": """",
            ""vcs-repo"": {
                ""identifier"": ""skierkowski/terraform-test-proj"",
                ""oauth-token-id"": ""ot-hmAyP66qk2AMVdbJ"",
                ""branch"": """"
            }
    },
    ""type"": ""workspaces""
    }
}";
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
    }
}