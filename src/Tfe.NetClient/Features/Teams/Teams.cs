namespace Tfe.NetClient.Teams
{
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Team
    /// </summary>
    public class Team : BaseClient
    {
        /// <summary>
        /// client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Team(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// ListAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        public async Task<TeamsResponse> ListAsync(string organizationName)
        {
            return await GetAsync<TeamsResponse>($"organizations/{organizationName}/teams").ConfigureAwait(false);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public async Task<TeamResponse> GetAsync(string teamId)
        {
            return await GetAsync<TeamResponse>($"teams/{teamId}").ConfigureAwait(false);
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="organizationName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TeamResponse> CreateAsync(string organizationName, TeamsRequest request)
        {
            return await PostAsync<TeamsRequest, TeamResponse>($"organizations/{organizationName}/teams", request).ConfigureAwait(false);
        }

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TeamResponse> UpdateAsync(string teamId, TeamsRequest request)
        {
            return await PatchAsync<TeamsRequest, TeamResponse>($"teams/{teamId}", request).ConfigureAwait(false);
        }

        /// <summary>
        /// DestroyAsync
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public async Task DestroyAsync(string teamId)
        {
            await DeleteAsync($"teams/{teamId}").ConfigureAwait(false);
        }
    }
}