namespace Tfe.NetClient.Organizations
{
    using System.Net.Http;
    using System.Threading.Tasks;


    public class Organization : BaseClient
    {
        public Organization(HttpClient client) : base(client)
        {
        }

        public async Task<OrganizationsResponse> ListAsync()
        {
            return await GetAsync<OrganizationsResponse>($"organizations").ConfigureAwait(false);
        }

        public async Task<OrganizationResponse> ShowAsync(string organizationName)
        {
            return await GetAsync<OrganizationResponse>($"organizations/{organizationName}").ConfigureAwait(false);
        }

        public async Task<OrganizationResponse> CreateAsync(OrganizationRequest request)
        {
            return await PostAsync<OrganizationRequest, OrganizationResponse>($"organizations", request).ConfigureAwait(false);
        }

        public async Task<OrganizationResponse> UpdateAsync(OrganizationRequest request)
        {
            return await PatchAsync<OrganizationRequest, OrganizationResponse>($"organizations", request).ConfigureAwait(false);
        }

        public async Task DestroyAsync(string organizationName)
        {
            await DeleteAsync($"organizations/{organizationName}").ConfigureAwait(false);
        }
    }
}