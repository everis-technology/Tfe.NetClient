namespace Tfe.NetClient.OAuthClients
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class OAuthClient
    {
        HttpClient client;

        public OAuthClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<OAuthClientsResponse> ListAsync(string organizationName)
        {
            var result = await client.GetAsync($"organizations/{organizationName}/oauth-clients").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organizations = JsonSerializer.Deserialize<OAuthClientsResponse>(content);
            return organizations;
        }

        public async Task<OAuthClientsResponse> ShowAsync(string oauthClientId)
        {
            var result = await client.GetAsync($"oauth-clients/{oauthClientId}").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organization = JsonSerializer.Deserialize<OAuthClientsResponse>(content);
            return organization;
        }

        public async Task<OAuthClientResponse> CreateAsync(string organizationName, OAuthClientsRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");
            
            var result = await client.PostAsync($"organizations/{organizationName}/oauth-clients", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<OAuthClientResponse>(resultContent);
            return organization;
        }

        public async Task<OAuthClientResponse> UpdateAsync(OAuthClientsRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var requestMessage = new HttpRequestMessage(new HttpMethod("PATCH"), "organizations");
            requestMessage.Content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.SendAsync(requestMessage).ConfigureAwait(false); ;
            result.EnsureSuccessStatusCode();
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<OAuthClientResponse>(content);
            return organization;
        }

        public async Task DestroyAsync(string oauthClientId)
        {
            var result = await client.DeleteAsync($"oauth-clients/{oauthClientId}").ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }
    }
}