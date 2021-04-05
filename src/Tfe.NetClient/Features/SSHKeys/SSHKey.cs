namespace Tfe.NetClient.SshKeys
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// SshKey
    /// </summary>
    public class SshKey : BaseClient
    {
        /// <summary>
        /// SshKey
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public SshKey(HttpClient client) : base(client)
        {

        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        public async Task<SshKeysResponse> ListAsync(string organizationName)
        {
            return await GetAsync<SshKeysResponse>($"organizations/{organizationName}/ssh-keys").ConfigureAwait(false);
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SshKeyResponse> CreateAsync(string organizationName, SshKeyRequest request)
        {
            return await PostAsync<SshKeyRequest, SshKeyResponse>($"organizations/{organizationName}/ssh-keys", request).ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="shhKeyId"></param>
        /// <returns></returns>
        public async Task<SshKeyResponse> GetAsync(string shhKeyId)
        {
            return await GetAsync<SshKeyResponse>($"ssh-keys/{shhKeyId}").ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="shhKeyId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SshKeyResponse> UpdateAsync(string shhKeyId, SshKeyRequest request)
        {
            return await PatchAsync<SshKeyRequest, SshKeyResponse>($"ssh-keys/{shhKeyId}", request).ConfigureAwait(false);
        }

        /// <summary>
        /// DestroyAsync
        /// </summary>
        /// <param name="shhKeyId"></param>
        /// <returns></returns>
        public async Task DestroyAsync(string shhKeyId)
        {
            await DeleteAsync($"ssh-keys/{shhKeyId}").ConfigureAwait(false);
        }
    }
}