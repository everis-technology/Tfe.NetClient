namespace Tfe.NetClient.OAuthTokens
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// OAuthToken
    /// </summary>
    public class OAuthToken : BaseClient
    {

        /// <summary>
        /// OAuthToken
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public OAuthToken(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <param name="oauthClientId"></param>
        /// <returns></returns>
        public async Task<OAuthTokensResponse> ListAsync(string oauthClientId)
        {
            return await GetAsync<OAuthTokensResponse>($"oauth-clients/{oauthClientId}/oauth-tokens").ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="oauthTokenId"></param>
        /// <returns></returns>
        public async Task<OAuthTokenResponse> GetAsync(string oauthTokenId)
        {
            return await GetAsync<OAuthTokenResponse>($"oauth-tokens/{oauthTokenId}").ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="oauthTokenId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<OAuthTokenResponse> UpdateAsync(string oauthTokenId, OAuthTokensRequest request)
        {
            return await PatchAsync<OAuthTokensRequest, OAuthTokenResponse>($"/oauth-tokens/{oauthTokenId}", request).ConfigureAwait(false);
        }

        /// <summary>
        /// DestroyAsync
        /// </summary>
        /// <param name="oauthTokenId"></param>
        /// <returns></returns>
        public async Task DestroyAsync(string oauthTokenId)
        {
            await DeleteAsync($"oauth-tokens/{oauthTokenId}").ConfigureAwait(false);
        }
    }
}