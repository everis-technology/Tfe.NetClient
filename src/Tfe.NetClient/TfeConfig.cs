namespace Tfe.NetClient
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    
    /// <summary>
    /// TfeConfig
    /// </summary>
    public class TfeConfig
    {   
        /// <summary>
        /// TfeConfig
        /// </summary>
        /// <param name="token"></param>
        /// <param name="client"></param>
        public TfeConfig(string token, HttpClient client) : this("https://app.terraform.io/api/v2/", token, client)
        {
        }

        /// <summary>
        /// TfeConfig
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="token"></param>
        /// <param name="client"></param>
        public TfeConfig(string endpoint, string token, HttpClient client)
        {
            HttpClient = client;
            HttpClient.BaseAddress = new System.Uri(endpoint);
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        /// <summary>
        /// HttpClient
        /// </summary>
        /// <value></value>
        public HttpClient HttpClient { get; }
    }
}

