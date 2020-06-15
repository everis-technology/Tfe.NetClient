namespace Tfe.NetClient.Runs
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class Run
    {
        HttpClient client;

        public Run(HttpClient client)
        {
            this.client = client;
        }

        public async Task<RunResponse> CreateAsync(RunsRequest request)
        {
            var serializerJsonOptions = new JsonSerializerOptions()
            {
                IgnoreNullValues = true
            };
            var parameters = JsonSerializer.Serialize(request, serializerJsonOptions);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"runs", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<RunResponse>(resultContent);
            return organization;
        }

        public async Task ApplyAsync(string runId, CommentRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"runs/{runId}/actions/apply", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }

        public async Task<RunsResponse> ListAsync(string workSpaceId)
        {
            var result = await client.GetAsync($"workspaces/{workSpaceId}/runs").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organizations = JsonSerializer.Deserialize<RunsResponse>(content);
            return organizations;
        }

        public async Task<RunResponse> ShowAsync(string runId)
        {
            var result = await client.GetAsync($"runs/{runId}").ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var organization = JsonSerializer.Deserialize<RunResponse>(content);
            return organization;
        }

        public async Task DiscardAsync(string runId, CommentRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"runs/{runId}/actions/discard", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }

        public async Task CancelAsync(string runId, CommentRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"runs/{runId}/actions/cancel", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }

        public async Task ForceRunAsync(string runId, CommentRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"runs/{runId}/actions/force-execute", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }

        public async Task ForceCancelAsync(string runId, CommentRequest request)
        {
            var parameters = JsonSerializer.Serialize(request);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync($"runs/{runId}/actions/force-cancel", content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }
    }
}