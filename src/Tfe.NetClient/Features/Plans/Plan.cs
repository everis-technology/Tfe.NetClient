using System.Net.Http;
using System.Threading.Tasks;

namespace Tfe.NetClient.Plans
{
	public class Plan : BaseClient
	{
		public Plan(HttpClient client) : base(client)
		{
		}

		/// <summary>
		/// GetPlanAsync
		/// </summary>
		/// <param name="planId"></param>
		/// <returns></returns>
		public async Task<PlansResponse> GetPlanAsync(string planId)
		{
			return await GetAsync<PlansResponse>($"plans/{planId}").ConfigureAwait(false);
		}
	}
}
