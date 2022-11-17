using System.Net.Http;
using System.Net.Http.Headers;
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


        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ConfigurationVersionsResponse> CreateAsync(string workspaceId, ConfigurationVersionRequest request)
        {
            return await PostAsync<ConfigurationVersionRequest, ConfigurationVersionsResponse>($"workspaces/{workspaceId}/configuration-versions", request).ConfigureAwait(false);
        }


        /// <summary>
        /// PutAsync
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="uploadURL"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PutAsync(string filename, string uploadURL)
        {

            var filebytes = System.IO.File.ReadAllBytes(filename);

            using (var content = new ByteArrayContent(filebytes))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                return await client.PutAsync(uploadURL, content).ConfigureAwait(false); 
            }

        }

    }
}