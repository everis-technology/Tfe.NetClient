namespace Tfe.NetClient.OAuthClients
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class OAuthClient : BaseClient
    {

        public OAuthClient(HttpClient client) : base(client)
        {
        }

        public async Task<OAuthClientsResponse> ListAsync(string organizationName)
        {
            return await GetAsync<OAuthClientsResponse>($"organizations/{organizationName}/oauth-clients").ConfigureAwait(false);
        }

        public async Task<OAuthClientResponse> ShowAsync(string oauthClientId)
        {
            return await GetAsync<OAuthClientResponse>($"oauth-clients/{oauthClientId}").ConfigureAwait(false);
        }

        public async Task<OAuthClientResponse> CreateAsync(string organizationName, OAuthClientsRequest request)
        {
            return await PostAsync<OAuthClientsRequest, OAuthClientResponse>($"organizations/{organizationName}/oauth-clients", request).ConfigureAwait(false);
        }

        public async Task<OAuthClientResponse> UpdateAsync(OAuthClientsRequest request)
        {
            return await PatchAsync<OAuthClientsRequest, OAuthClientResponse>($"organizations", request).ConfigureAwait(false);
        }

        public async Task DestroyAsync(string oauthClientId)
        {
            await DeleteAsync($"oauth-clients/{oauthClientId}").ConfigureAwait(false);
        }
    }
}