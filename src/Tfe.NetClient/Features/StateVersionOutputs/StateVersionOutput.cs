namespace Tfe.NetClient.StateVersionOutputs
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Apply
    /// </summary>
    public class StateVersionOutput : BaseClient
    {

        /// <summary>
        /// StateVersionOutput
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public StateVersionOutput(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="stateVersionOutputId"></param>
        /// <returns></returns>
        public async Task<StateVersionOutputResponse> GetAsync(string stateVersionOutputId)
        {
            return await GetAsync<StateVersionOutputResponse>($"state-version-outputs/{stateVersionOutputId}").ConfigureAwait(false);
        }
    }
}