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
        /// ShowConfigurationVersionsAsync
        /// </summary>
        /// <param name="configurationVersionId"></param>
        /// <returns></returns>
        public async Task<ConfigurationVersionsResponse> ShowConfigurationVersionsAsync(string configurationVersionId)
        {
            return await GetAsync<ConfigurationVersionsResponse>($"configuration-versions/{configurationVersionId}").ConfigureAwait(false);
        }

        /// <summary>
        /// ShowIngressAttributesAsync
        /// </summary>
        /// <param name="configurationVersionId"></param>
        /// <returns></returns>
        public async Task<IngressAttributesResponse> ShowIngressAttributesAsync(string configurationVersionId)
        {
            return await GetAsync<IngressAttributesResponse>($"configuration-versions/{configurationVersionId}/ingress-attributes").ConfigureAwait(false);
        }
    }
}