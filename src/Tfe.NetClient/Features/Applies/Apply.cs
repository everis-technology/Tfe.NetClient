namespace Tfe.NetClient.Applies
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Apply
    /// </summary>
    public class Apply : BaseClient
    {

        /// <summary>
        /// OAuthClient
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Apply(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="applyId"></param>
        /// <returns></returns>
        public async Task<ApplyResponse> GetAsync(string applyId)
        {
            return await GetAsync<ApplyResponse>($"applies/{applyId}").ConfigureAwait(false);
        }
    }
}