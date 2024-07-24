namespace Tfe.NetClient.StateVersions
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// OAuthClient
    /// </summary>
    public class StateVersion : BaseClient
    {

        /// <summary>
        /// StateVersion
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public StateVersion(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="stateVersionId"></param>
        /// <returns></returns>
        public async Task<StateVersionResponse> GetAsync(string stateVersionId)
        {
            return await GetAsync<StateVersionResponse>($"state-versions/{stateVersionId}").ConfigureAwait(false);
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<StateVersionResponse> CreateAsync(string workspaceId, StateVersionRequest request)
        {
            return await PostAsync<StateVersionRequest, StateVersionResponse>($"workspaces/{workspaceId}/state-versions", request).ConfigureAwait(false);
        }

        /// <summary>
        /// GetCurrentAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <returns></returns>
        public async Task<StateVersionResponse> GetCurrentAsync(string workspaceId)
        {
            return await GetAsync<StateVersionResponse>($"workspaces/{workspaceId}/current-state-version").ConfigureAwait(false);
        }
    }
}