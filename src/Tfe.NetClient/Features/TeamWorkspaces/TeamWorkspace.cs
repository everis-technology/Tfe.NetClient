namespace Tfe.NetClient.TeamWorkspaces
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class TeamWorkspace : BaseClient
    {
        /// <summary>
        /// client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public TeamWorkspace(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        public async Task<TeamWorkspacesResponse> ListAsync(string workspaceId)
        {
            return await GetAsync<TeamWorkspacesResponse>($"team-workspaces?filter[workspace][id]={workspaceId}").ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="teamWorkspaceId"></param>
        /// <returns></returns>
        public async Task<TeamWorkspaceResponse> GetAsync(string teamWorkspaceId)
        {
            return await GetAsync<TeamWorkspaceResponse>($"team-workspaces/{teamWorkspaceId}").ConfigureAwait(false);
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TeamWorkspaceResponse> CreateAsync(Request request)
        {
            return await PostAsync<Request, TeamWorkspaceResponse>($"team-workspaces", request).ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="teamWorkspaceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TeamWorkspaceResponse> UpdateAsync(string teamWorkspaceId, UpdateRequest request)
        {
            return await PatchAsync<UpdateRequest, TeamWorkspaceResponse>($"team-workspaces/{teamWorkspaceId}", request).ConfigureAwait(false);
        }

        /// <summary>
        /// DestroyAsync
        /// </summary>
        /// <param name="teamWorkspaceId"></param>
        /// <returns></returns>
        public async Task DestroyAsync(string teamWorkspaceId)
        {
            await DeleteAsync($"team-workspaces/{teamWorkspaceId}");
        }
    }
}
