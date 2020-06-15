namespace Tfe.NetClient
{
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class TfeConfig
    {
        public TfeConfig(string token, HttpClient client) : this("https://app.terraform.io/api/v2/", token, client)
        {
        }

        public TfeConfig(string endpoint, string token, HttpClient client)
        {
            HttpClient = client;
            HttpClient.BaseAddress = new System.Uri(endpoint);
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public HttpClient HttpClient { get; }
    }
}

