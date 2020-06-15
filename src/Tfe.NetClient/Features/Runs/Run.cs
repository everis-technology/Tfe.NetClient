namespace Tfe.NetClient.Runs
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Run : BaseClient
    {
        public Run(HttpClient client) : base(client)
        {

        }

        public async Task<RunResponse> CreateAsync(RunsRequest request)
        {
            return await PostAsync<RunsRequest, RunResponse>("runs", request).ConfigureAwait(false);
        }

        public async Task ApplyAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/apply", request).ConfigureAwait(false);
        }

        public async Task<RunsResponse> ListAsync(string workSpaceId)
        {
            return await GetAsync<RunsResponse>($"workspaces/{workSpaceId}/runs").ConfigureAwait(false);
        }

        public async Task<RunResponse> ShowAsync(string runId)
        {
            return await GetAsync<RunResponse>($"runs/{runId}").ConfigureAwait(false);
        }

        public async Task DiscardAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/discard", request).ConfigureAwait(false);
        }

        public async Task CancelAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/cancel", request).ConfigureAwait(false);
        }

        public async Task ForceRunAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/force-execute", request).ConfigureAwait(false);
        }

        public async Task ForceCancelAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/force-cancel", request).ConfigureAwait(false);
        }
    }
}