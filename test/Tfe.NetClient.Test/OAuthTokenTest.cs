namespace Tfe.NetClient
{
    using Xunit;
    using System.Threading.Tasks;
    using System.Linq;
    using Tfe.NetClient.OAuthTokens;
    using System;

    /// <summary>
    /// WorkspaceTest
    /// </summary>
    public class OAuthTokenTest
    {
        /// <summary>
        /// List_OAuthToken
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task List_OAuthToken()
        {
            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("OAuthToken/ListOAuthTokens", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var oauthClientId = "oc-GhHqb5rkeK19mLB8";
            var result = await client.OAuthToken.ListAsync(oauthClientId);
            Assert.NotNull(result);
            Assert.Single(result.Data);
            Assert.Equal("ot-hmAyP66qk2AMVdbJ", result.Data[0].Id);
            Assert.Equal(oauthClientId, result.Data[0].Relationships.OAuthClients.Data[0].Id);
        }

        /// <summary>
        /// Get_OAuthToken
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Get_OAuthToken()
        {
            var oauthTokenId = "ot-29t7xkUKiNC2XasL";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("OAuthToken/GetOAuthToken", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);
            var client = new TfeClient(config);
            var result = await client.OAuthToken.GetAsync(oauthTokenId);
            Assert.NotNull(result);
            Assert.Equal(oauthTokenId, result.Data.Id);
        }
    }
}