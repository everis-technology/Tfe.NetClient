namespace Tfe.NetClient.WorkspaceVariables
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class WorkspaceVariable
    {
        HttpClient client;

        public WorkspaceVariable(HttpClient client)
        {
            this.client = client;
        }

        // public async Task<WorkspacesResponse> ListAsync(string organizationName)
        // {
        //     var result = await client.GetAsync($"organizations/{organizationName}/workspaces").ConfigureAwait(false);
        //     var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
        //     result.EnsureSuccessStatusCode();
        //     var organizations = JsonSerializer.Deserialize<WorkspacesResponse>(content);
        //     return organizations;
        // }

        public async Task<WorkspaceVariableResponse> CreateAsync(string workspaceId, WorkspaceVariablesRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);

            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"workspaces/{workspaceId}/vars", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<WorkspaceVariableResponse>(resultContent);
            return organization;
        }

        // public async Task<WorkspaceResponse> UpdateAsync(string workspaceId, WorkspacesRequest request)
        // {
        //     var parameters = JsonSerializer.Serialize(request);
        //     var requestMessage = new HttpRequestMessage(new HttpMethod("PATCH"), $"workspaces/{workspaceId}");
        //     requestMessage.Content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
        //     requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

        //     var result = await client.SendAsync(requestMessage).ConfigureAwait(false); ;
        //     result.EnsureSuccessStatusCode();
        //     var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
        //     var organization = JsonSerializer.Deserialize<WorkspaceResponse>(content);
        //     return organization;
        // }

        // public async Task<WorkspaceResponse> UpdateAsync(string organizationName, string workspaceName, WorkspacesRequest request)
        // {
        //     var parameters = JsonSerializer.Serialize(request);
        //     var requestMessage = new HttpRequestMessage(new HttpMethod("PATCH"), $"organizations/{organizationName}/workspaces/{workspaceName}");
        //     requestMessage.Content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
        //     requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

        //     var result = await client.SendAsync(requestMessage).ConfigureAwait(false); ;
        //     result.EnsureSuccessStatusCode();
        //     var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
        //     var organization = JsonSerializer.Deserialize<WorkspaceResponse>(content);
        //     return organization;
        // }

        // public async Task<WorkspaceResponse> ShowAsync(string workspaceId)
        // {
        //     var result = await client.GetAsync($"workspaces/{workspaceId}").ConfigureAwait(false);
        //     var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
        //     result.EnsureSuccessStatusCode();
        //     var organization = JsonSerializer.Deserialize<WorkspaceResponse>(content);
        //     return organization;
        // }

        // public async Task<WorkspaceResponse> ShowAsync(string organizationName, string workspaceName)
        // {
        //     var result = await client.GetAsync($"organizations/{organizationName}/workspaces/{workspaceName}").ConfigureAwait(false);
        //     var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
        //     result.EnsureSuccessStatusCode();
        //     var organization = JsonSerializer.Deserialize<WorkspaceResponse>(content);
        //     return organization;
        // }

        // public async Task DeleteAsync(string workspaceId)
        // {
        //     var result = await client.DeleteAsync($"workspaces/{workspaceId}").ConfigureAwait(false);
        //     result.EnsureSuccessStatusCode();
        // }

        // public async Task DeleteAsync(string organizationName, string workspaceName)
        // {
        //     var result = await client.DeleteAsync($"organizations/{organizationName}/workspaces/{workspaceName}").ConfigureAwait(false);
        //     result.EnsureSuccessStatusCode();
        // }
    }
}