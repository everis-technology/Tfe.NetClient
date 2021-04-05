namespace Tfe.NetClient.Organizations
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Organization
    /// </summary>
    public class Organization : BaseClient
    {
        /// <summary>
        /// Organization
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Organization(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <returns></returns>
        public async Task<OrganizationsResponse> ListAsync()
        {
            return await GetAsync<OrganizationsResponse>($"organizations").ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        public async Task<OrganizationResponse> GetAsync(string organizationName)
        {
            return await GetAsync<OrganizationResponse>($"organizations/{organizationName}").ConfigureAwait(false);
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<OrganizationResponse> CreateAsync(OrganizationRequest request)
        {
            return await PostAsync<OrganizationRequest, OrganizationResponse>($"organizations", request).ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<OrganizationResponse> UpdateAsync(OrganizationRequest request)
        {
            return await PatchAsync<OrganizationRequest, OrganizationResponse>($"organizations", request).ConfigureAwait(false);
        }

        /// <summary>
        /// DestroyAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        public async Task DestroyAsync(string organizationName)
        {
            await DeleteAsync($"organizations/{organizationName}").ConfigureAwait(false);
        }
    }
}