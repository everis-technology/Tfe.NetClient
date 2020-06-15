namespace Tfe.NetClient.SshKeys
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class SshKey : BaseClient
    {
        public SshKey(HttpClient client) : base(client)
        {

        }

        public async Task<SshKeysResponse> ListAsync(string organizationName)
        {
            return await GetAsync<SshKeysResponse>($"organizations/{organizationName}/ssh-keys").ConfigureAwait(false);
        }

        public async Task<SshKeyResponse> CreateAsync(string organizationName, SshKeyRequest request)
        {
            return await PostAsync<SshKeyRequest, SshKeyResponse>($"organizations/{organizationName}/ssh-keys", request).ConfigureAwait(false);
        }

        public async Task<SshKeyResponse> ShowAsync(string shhKeyId)
        {
            return await GetAsync<SshKeyResponse>($"ssh-keys/{shhKeyId}").ConfigureAwait(false);
        }

        public async Task<SshKeyResponse> UpdateAsync(string shhKeyId, SshKeyRequest request)
        {
            return await PatchAsync<SshKeyRequest, SshKeyResponse>($"ssh-keys/{shhKeyId}", request).ConfigureAwait(false);
        }

        public async Task DestroyAsync(string shhKeyId)
        {
            await DeleteAsync($"ssh-keys/{shhKeyId}").ConfigureAwait(false);
        }
    }
}