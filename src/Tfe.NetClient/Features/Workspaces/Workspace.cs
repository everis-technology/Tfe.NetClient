namespace Tfe.NetClient.Workspaces
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// Workspace
    /// </summary>
    public class Workspace : BaseClient
    {
        /// <summary>
        /// client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>

        public Workspace(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        public async Task<WorkspacesResponse> ListAsync(string organizationName)
        {
            return await GetAsync<WorkspacesResponse>($"organizations/{organizationName}/workspaces").ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <returns></returns>
        public async Task<WorkspaceResponse> GetAsync(string workspaceId)
        {
            return await GetAsync<WorkspaceResponse>($"workspaces/{workspaceId}").ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="workspaceName"></param>
        /// <returns></returns>
        public async Task<WorkspaceResponse> GetAsync(string organizationName, string workspaceName)
        {
            return await GetAsync<WorkspaceResponse>($"organizations/{organizationName}/workspaces/{workspaceName}").ConfigureAwait(false);
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<WorkspaceResponse> CreateAsync(string organizationName, WorkspacesRequest request)
        {
            return await PostAsync<WorkspacesRequest, WorkspaceResponse>($"organizations/{organizationName}/workspaces", request).ConfigureAwait(false);
        }

        /// <summary>
        /// LockAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> LockAsync(string workspaceId)
        {
            return await PostAsync<string, HttpResponseMessage>($"workspaces/{workspaceId}/actions/lock", "").ConfigureAwait(false);
        }


        /// <summary>
        /// UnlockAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> UnlockAsync(string workspaceId)
        {
            return await PostAsync<string, HttpResponseMessage>($"workspaces/{workspaceId}/actions/unlock", "").ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<WorkspaceResponse> UpdateAsync(string workspaceId, WorkspacesRequest request)
        {
            return await PatchAsync<WorkspacesRequest, WorkspaceResponse>($"workspaces/{workspaceId}", request).ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="workspaceName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<WorkspaceResponse> UpdateAsync(string organizationName, string workspaceName, WorkspacesRequest request)
        {
            return await PatchAsync<WorkspacesRequest, WorkspaceResponse>($"organizations/{organizationName}/workspaces/{workspaceName}", request).ConfigureAwait(false);
        }

        /// <summary>
        /// DestroyAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <returns></returns>
        public async Task DestroyAsync(string workspaceId)
        {
            await DeleteAsync($"workspaces/{workspaceId}");
        }

        /// <summary>
        /// DeleteAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="workspaceName"></param>
        /// <returns></returns>
        public async Task DeleteAsync(string organizationName, string workspaceName)
        {
            await DeleteAsync($"organizations/{organizationName}/workspaces/{workspaceName}").ConfigureAwait(false);
        }

        /// <summary>
        /// AssignSshKeyAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<WorkspaceResponse> AssignSshKeyAsync(string workspaceId, AssignSsshKeyRequest request)
        {
            return await PatchAsync<AssignSsshKeyRequest, WorkspaceResponse>($"workspaces/{workspaceId}/relationships/ssh-key", request).ConfigureAwait(false);
        }
    }
}