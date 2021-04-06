using System.Net.Http;
using System.Threading.Tasks;

namespace Tfe.NetClient.Features.ConfigurationVersions
{
    public class ConfigurationVersion : BaseClient
    {
        /// <summary>
        /// client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public ConfigurationVersion(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// GetConfigurationVersionsAsync
        /// </summary>
        /// <param name="configurationVersionId"></param>
        /// <returns></returns>
        public async Task<ConfigurationVersionsResponse> GetConfigurationVersionsAsync(string configurationVersionId)
        {
            return await GetAsync<ConfigurationVersionsResponse>($"configuration-versions/{configurationVersionId}").ConfigureAwait(false);
        }

        /// <summary>
        /// GetIngressAttributesAsync
        /// </summary>
        /// <param name="configurationVersionId"></param>
        /// <returns></returns>
        public async Task<IngressAttributesResponse> GetIngressAttributesAsync(string configurationVersionId)
        {
            return await GetAsync<IngressAttributesResponse>($"configuration-versions/{configurationVersionId}/ingress-attributes").ConfigureAwait(false);
        }
    }
}