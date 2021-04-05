namespace Tfe.NetClient
{
    using Xunit;
    using System.Threading.Tasks;
    using System.Linq;
    using Tfe.NetClient.OAuthClients;
    using System;

    /// <summary>
    /// WorkspaceTest
    /// </summary>
    public class OAuthClientTest
    {
        /// <summary>
        /// Create_OAuthClient
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Create_OAuthClient()
        {
            var organizationName = "my-organization";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("OAuthClient/CreateOAuthClient", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var request = new OAuthClientsRequest();
            request.Data.Attributes.ServiceProvider = "github";
            request.Data.Attributes.HttpUrl = new Uri("https://github.com");
            request.Data.Attributes.ApiUrl = new Uri("https://api.github.com");
            request.Data.Attributes.OAuthTokenString = "4306823352f0009d0ed81f1b654ac17a";

            var result = await client.OAuthClient.CreateAsync(organizationName, request);
            Assert.NotNull(result);
            Assert.Equal(organizationName, result.Data.Relationships.Organization.Data.Id);
            Assert.Equal(request.Data.Attributes.ServiceProvider, result.Data.Attributes.ServiceProvider);
            Assert.Equal(request.Data.Attributes.HttpUrl, result.Data.Attributes.HttpUrl);
            Assert.Equal(request.Data.Attributes.ApiUrl, result.Data.Attributes.ApiUrl);
            Assert.Equal("/api/v2/oauth-tokens/ot-KaeqH4cy72VPXFQT", result.Data.Relationships.OAuthTokens.Links.Related);
        }

        // TODO: We don't have a request object for OAuthClient Update
        // /// <summary>
        // /// Update_OAuthClient
        // /// </summary>
        // /// <returns></returns>
        // [Fact]
        // public async Task Update_OAuthClient()
        // {
        //     var httpClient = new TestHttpClient()
        //     {
        //         Handler = (entry) =>
        //            {
        //                TestHttpClient.SendResponse("OAuthClient/UpdateOAuthClient", entry);
        //            }
        //     };

        //     var config = new TfeConfig("faketoken", httpClient);

        //     var client = new TfeClient(config);

        //     var oauthClientId = "oc-XKFwG6ggfA9n7t1K";
        //     var request = new OAuthClientsRequest();

        //     request.Data.Attributes.PrivateKey = "key";
        //     request.Data.Attributes.

        //     var result = await client.OAuthClient.UpdateAsync(oauthClientId, request);
        //     Assert.NotNull(result);
        //     Assert.Equal(OAuthClientName, result.Data.Attributes.Name);
        //     Assert.Equal("skierkowski/terraform-test-proj", result.Data.Attributes.VcsRepo.Identifier);
        //     Assert.Equal("ot-hmAyP66qk2AMVdbJ", result.Data.Attributes.VcsRepo.OauthTokenId);
        // }

        /// <summary>
        /// List_Workspace
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task List_OAuthClient()
        {
            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("OAuthClient/ListOAuthClient", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var organizationName = "my-organization";
            var result = await client.OAuthClient.ListAsync(organizationName);
            Assert.NotNull(result);
            Assert.Single(result.Data);
            Assert.Equal("oc-XKFwG6ggfA9n7t1K", result.Data[0].Id);
            Assert.Equal(organizationName, result.Data[0].Relationships.Organization.Data.Id);
        }

        /// <summary>
        /// Get_OAuthClient
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Get_OAuthClient()
        {
            var oauthClientId = "oc-XKFwG6ggfA9n7t1K";

            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                   {
                       TestHttpClient.SendResponse("OAuthClient/GetOAuthClient", entry);
                   }
            };

            var config = new TfeConfig("faketoken", httpClient);

            var client = new TfeClient(config);

            var result = await client.OAuthClient.GetAsync(oauthClientId);
            Assert.NotNull(result);
            Assert.Equal(oauthClientId, result.Data.Id);
        }
    }
}