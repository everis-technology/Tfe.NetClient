namespace Tfe.NetClient.Workspaces
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class Workspace : BaseClient
    {

        public Workspace(HttpClient client) : base(client)
        {
        }

        public async Task<WorkspacesResponse> ListAsync(string organizationName)
        {
            return await GetAsync<WorkspacesResponse>($"organizations/{organizationName}/workspaces").ConfigureAwait(false);
        }

        public async Task<WorkspaceResponse> ShowAsync(string workspaceId)
        {
            return await GetAsync<WorkspaceResponse>($"workspaces/{workspaceId}").ConfigureAwait(false);
        }

        public async Task<WorkspaceResponse> ShowAsync(string organizationName, string workspaceName)
        {
            return await GetAsync<WorkspaceResponse>($"organizations/{organizationName}/workspaces/{workspaceName}").ConfigureAwait(false);
        }

        public async Task<WorkspaceResponse> CreateAsync(string organizationName, WorkspacesRequest request)
        {
            return await PostAsync<WorkspacesRequest, WorkspaceResponse>($"organizations/{organizationName}/workspaces", request).ConfigureAwait(false);
        }

        public async Task<WorkspaceResponse> UpdateAsync(string workspaceId, WorkspacesRequest request)
        {
            return await PatchAsync<WorkspacesRequest, WorkspaceResponse>($"workspaces/{workspaceId}", request).ConfigureAwait(false);
        }

        public async Task<WorkspaceResponse> UpdateAsync(string organizationName, string workspaceName, WorkspacesRequest request)
        {
            return await PatchAsync<WorkspacesRequest, WorkspaceResponse>($"organizations/{organizationName}/workspaces/{workspaceName}", request).ConfigureAwait(false);
        }

        public async Task DestroyAsync(string workspaceId)
        {
            await DeleteAsync($"workspaces/{workspaceId}");
        }

        public async Task DeleteAsync(string organizationName, string workspaceName)
        {
            await DeleteAsync($"organizations/{organizationName}/workspaces/{workspaceName}").ConfigureAwait(false);
        }
    }
}