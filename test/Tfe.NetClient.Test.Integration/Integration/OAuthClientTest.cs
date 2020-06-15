namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Microsoft.Extensions.Configuration;
    using Tfe.NetClient.OAuthClients;
    using System;
    using System.Threading.Tasks;
    using Xunit.Extensions.Ordering;

    [Order(1)]
    public class OAuthClientTest : IClassFixture<IntegrationTestFixture>
    {
        private readonly IConfiguration configuration;

        public OAuthClientTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        [Fact, Order(1)]
        public async Task CreateOAuthClient()
        {
            var organizationName = configuration["organizationName"];

            var httpClient = new HttpClient();
            var config = new TfeConfig(configuration["teamToken"], httpClient);

            var client = new TfeClient(config);

            var request = new OAuthClientsRequest();
            request.Data.Attributes.ServiceProvider = "github";
            request.Data.Attributes.HttpUrl = new Uri("https://github.com");
            request.Data.Attributes.ApiUrl = new Uri("https://api.github.com");
            request.Data.Attributes.OAuthTokenString = configuration["gitToken"];

            var result = await client.OAuthClient.CreateAsync(organizationName, request);
            Assert.NotNull(result);
            IntegrationContext.OAuthTokenId = result.Data.Relationships.OAuthTokens.Data[0].Id;
        }
    }
}