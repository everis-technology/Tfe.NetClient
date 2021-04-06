namespace Tfe.NetClient.OAuthClients
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// OAuthClient
    /// </summary>
    public class OAuthClient : BaseClient
    {

        /// <summary>
        /// OAuthClient
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public OAuthClient(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        public async Task<OAuthClientsResponse> ListAsync(string organizationName)
        {
            return await GetAsync<OAuthClientsResponse>($"organizations/{organizationName}/oauth-clients").ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <returns></returns>
        public async Task<OAuthClientResponse> GetAsync(string oauthClientId)
        {
            return await GetAsync<OAuthClientResponse>($"oauth-clients/{oauthClientId}").ConfigureAwait(false);
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<OAuthClientResponse> CreateAsync(string organizationName, OAuthClientsRequest request)
        {
            return await PostAsync<OAuthClientsRequest, OAuthClientResponse>($"organizations/{organizationName}/oauth-clients", request).ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<OAuthClientResponse> UpdateAsync(string oauthClientId, OAuthClientsRequest request)
        {
            return await PatchAsync<OAuthClientsRequest, OAuthClientResponse>($"/oauth-clients/{oauthClientId}", request).ConfigureAwait(false);
        }

        /// <summary>
        /// DestroyAsync
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <returns></returns>
        public async Task DestroyAsync(string oauthClientId)
        {
            await DeleteAsync($"oauth-clients/{oauthClientId}").ConfigureAwait(false);
        }
    }
}