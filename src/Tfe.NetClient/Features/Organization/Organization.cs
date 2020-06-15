namespace Tfe.NetClient.Organizations
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class Organization
    {
        HttpClient client;

        public Organization(HttpClient client)
        {
            this.client = client;
        }

        public async Task<OrganizationsResponse> ListAsync()
        {
            var result = await client.GetAsync("organizations").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organizations = JsonSerializer.Deserialize<OrganizationsResponse>(content);
            return organizations;
        }

        public async Task<OrganizationResponse> CreateAsync(OrganizationRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync("organizations", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<OrganizationResponse>(resultContent);
            return organization;
        }

        public async Task<OrganizationResponse> ShowAsync(string organizationName)
        {
            var result = await client.GetAsync($"organizations/{organizationName}").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organization = JsonSerializer.Deserialize<OrganizationResponse>(content);
            return organization;
        }

        public async Task<OrganizationResponse> UpdateAsync(OrganizationRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var requestMessage = new HttpRequestMessage(new HttpMethod("PATCH"), "organizations");
            requestMessage.Content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.SendAsync(requestMessage).ConfigureAwait(false); ;
            result.EnsureSuccessStatusCode();
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<OrganizationResponse>(content);
            return organization;
        }

        public async Task DestroyAsync(string organizationName)
        {
            var result = await client.DeleteAsync($"organizations/{organizationName}").ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }
    }
}