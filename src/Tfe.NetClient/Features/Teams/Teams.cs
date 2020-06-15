namespace Tfe.NetClient.Teams
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Team : BaseClient
    {
        public Team(HttpClient client) : base(client)
        {
        }

        public async Task<TeamsResponse> ListAsync(string organizationName)
        {
            return await GetAsync<TeamsResponse>($"organizations/{organizationName}/teams").ConfigureAwait(false);
        }

        public async Task<TeamResponse> ShowAsync(string teamId)
        {
            return await GetAsync<TeamResponse>($"teams/{teamId}").ConfigureAwait(false);
        }

        public async Task<TeamResponse> CreateAsync(string organizationName, TeamsRequest request)
        {
            return await PostAsync<TeamsRequest, TeamResponse>($"organizations/{organizationName}/teams", request).ConfigureAwait(false);
        }

        public async Task<TeamResponse> UpdateAsync(string teamId, TeamsRequest request)
        {
            return await PatchAsync<TeamsRequest, TeamResponse>($"teams/{teamId}", request).ConfigureAwait(false);
        }

        public async Task DestroyAsync(string teamId)
        {
            await DeleteAsync($"teams/{teamId}").ConfigureAwait(false);
        }
    }
}