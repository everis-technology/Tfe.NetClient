namespace Tfe.NetClient.Teams
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class Team
    {
        HttpClient client;

        public Team(HttpClient client)
        {
            this.client = client;
        }

        public async Task<TeamsResponse> ListAsync(string organizationName)
        {
            var result = await client.GetAsync($"organizations/{organizationName}/teams").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organizations = JsonSerializer.Deserialize<TeamsResponse>(content);
            return organizations;
        }

        public async Task<TeamResponse> CreateAsync(string organizationName, TeamsRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"organizations/{organizationName}/teams", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<TeamResponse>(resultContent);
            return organization;
        }

        public async Task<TeamResponse> ShowAsync(string teamId)
        {
            var result = await client.GetAsync($"teams/{teamId}").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organization = JsonSerializer.Deserialize<TeamResponse>(content);
            return organization;
        }

        public async Task<TeamResponse> UpdateAsync(string teamId, TeamsRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var requestMessage = new HttpRequestMessage(new HttpMethod("PATCH"), $"teams/{teamId}");
            requestMessage.Content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.SendAsync(requestMessage).ConfigureAwait(false); ;
            result.EnsureSuccessStatusCode();
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<TeamResponse>(content);
            return organization;
        }

        public async Task DeleteAsync(string teamId)
        {
            var result = await client.DeleteAsync($"teams/{teamId}").ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }
    }
}