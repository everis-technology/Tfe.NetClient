namespace Tfe.NetClient.SshKeys
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class SshKey
    {
        HttpClient client;

        public SshKey(HttpClient client)
        {
            this.client = client;
        }

        public async Task<SshKeysResponse> ListAsync(string organizationName)
        {
            var result = await client.GetAsync($"organizations/{organizationName}/ssh-keys").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organizations = JsonSerializer.Deserialize<SshKeysResponse>(content);
            return organizations;
        }

        public async Task<SshKeyResponse> CreateAsync(string organizationName, SshKeyRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"organizations/{organizationName}/ssh-keys", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<SshKeyResponse>(resultContent);
            return organization;
        }

        public async Task<SshKeyResponse> ShowAsync(string shhKeyId)
        {
            var result = await client.GetAsync($"ssh-keys/{shhKeyId}").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organization = JsonSerializer.Deserialize<SshKeyResponse>(content);
            return organization;
        }

        public async Task<SshKeyResponse> UpdateAsync(string shhKeyId, SshKeyRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var requestMessage = new HttpRequestMessage(new HttpMethod("PATCH"), $"ssh-keys/{shhKeyId}");
            requestMessage.Content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.SendAsync(requestMessage).ConfigureAwait(false); ;
            result.EnsureSuccessStatusCode();
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<SshKeyResponse>(content);
            return organization;
        }

        public async Task DestroyAsync(string shhKeyId)
        {
            var result = await client.DeleteAsync($"ssh-keys/{shhKeyId}").ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }
    }
}