namespace Tfe.NetClient.Runs
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Run
    /// </summary>
    public class Run : BaseClient
    {
        /// <summary>
        /// Run
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Run(HttpClient client) : base(client)
        {

        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RunResponse> CreateAsync(RunsRequest request)
        {
            return await PostAsync<RunsRequest, RunResponse>("runs", request).ConfigureAwait(false);
        }

        /// <summary>
        /// ApplyAsync
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task ApplyAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/apply", request).ConfigureAwait(false);
        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <param name="workSpaceId"></param>
        /// <returns></returns>
        public async Task<RunsResponse> ListAsync(string workSpaceId)
        {
            return await GetAsync<RunsResponse>($"workspaces/{workSpaceId}/runs").ConfigureAwait(false);
        }

        /// <summary>
        /// ShowAsync
        /// </summary>
        /// <param name="runId"></param>
        /// <returns></returns>
        public async Task<RunResponse> ShowAsync(string runId)
        {
            return await GetAsync<RunResponse>($"runs/{runId}").ConfigureAwait(false);
        }

        /// <summary>
        /// DiscardAsync
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task DiscardAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/discard", request).ConfigureAwait(false);
        }

        /// <summary>
        /// CancelAsync
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task CancelAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/cancel", request).ConfigureAwait(false);
        }

        /// <summary>
        /// ForceRunAsync
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task ForceRunAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/force-execute", request).ConfigureAwait(false);
        }

        /// <summary>
        /// ForceCancelAsync
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task ForceCancelAsync(string runId, CommentRequest request)
        {
            await PostAsync<CommentRequest>($"runs/{runId}/actions/force-cancel", request).ConfigureAwait(false);
        }
    }
}