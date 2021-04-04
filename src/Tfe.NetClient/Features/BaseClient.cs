namespace Tfe.NetClient
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// BaseClient
    /// </summary>
    public class BaseClient
    {
        /// <summary>
        /// client
        /// </summary>
        protected HttpClient client;

        /// <summary>
        /// serializerJsonOptions
        /// </summary>
        /// <returns></returns>
        private JsonSerializerOptions serializerJsonOptions = new JsonSerializerOptions()
        {
            IgnoreNullValues = true
        };

        /// <summary>
        /// BaseClient
        /// </summary>
        /// <param name="client"></param>
        public BaseClient(HttpClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="Res"></typeparam>
        protected async Task<Res> GetAsync<Res>(string requestUri) where Res : class
        {
            var result = await client.GetAsync(requestUri).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var response = JsonSerializer.Deserialize<Res>(content, serializerJsonOptions);
            return response;
        }

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="Req"></typeparam>
        /// <typeparam name="Res"></typeparam>
        protected async Task<Res> PostAsync<Req, Res>(string requestUri, Req request) where Req : class where Res : class
        {
            var parameters = JsonSerializer.Serialize(request, serializerJsonOptions);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync(requestUri, content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var response = JsonSerializer.Deserialize<Res>(resultContent, serializerJsonOptions);
            return response;
        }

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="Req"></typeparam>
        protected async Task PostAsync<Req>(string requestUri, Req request) where Req : class
        {
            var parameters = JsonSerializer.Serialize(request, serializerJsonOptions);
            var content = new StringContent(parameters.ToString(), Encoding.UTF8, "application/vnd.api+json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.PostAsync(requestUri, content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// PatchAsync
        /// </summary>
        /// <typeparam name="Req"></typeparam>
        /// <typeparam name="Res"></typeparam>
        protected async Task<Res> PatchAsync<Req, Res>(string requestUri, Req request) where Req : class where Res : class
        {
            var parameters = JsonSerializer.Serialize(request, serializerJsonOptions);
            var requestMessage = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri);
            requestMessage.Content = new StringContent(parameters, Encoding.UTF8, "application/vnd.api+json");
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var result = await client.SendAsync(requestMessage).ConfigureAwait(false); ;
            result.EnsureSuccessStatusCode();
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var organization = JsonSerializer.Deserialize<Res>(content, serializerJsonOptions);
            return organization;
        }

        /// <summary>
        /// DeleteAsync
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        protected async Task DeleteAsync(string requestUri)
        {
            var result = await client.DeleteAsync(requestUri).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }
    }
}