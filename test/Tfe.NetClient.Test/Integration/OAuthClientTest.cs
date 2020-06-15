namespace Tfe.NetClient
{
    using Xunit;
    using System.Net.Http;
    using Microsoft.Extensions.Configuration;
    using Tfe.NetClient.OAuthClients;
    using System;
    using System.Threading.Tasks;

    public class OAuthClientTest : IClassFixture<IntegrationTestFixture>
    {
        private readonly IConfiguration configuration;

        public OAuthClientTest(IntegrationTestFixture fixture)
        {
            this.configuration = fixture.Configuration;
        }

        [Fact]
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
        }

        // [Fact]
        // public async Task ShowSshKey()
        // {
        //     var organizationName = configuration["organizationName"];

        //     var httpClient = new HttpClient();
        //     var config = new TfeConfig(configuration["teamToken"], httpClient);

        //     var client = new TfeClient(config);

        //     var request = new SshKeyRequest();
        //     var keyName = "test-sshkey-2";
        //     request.Data.Attributes.Name = keyName;
        //     request.Data.Attributes.Value = "-----BEGIN RSA PRIVATE KEY-----\nProc-Type: 4,ENCRYPTED\nDEK-Info: DES-EDE3-CBC,AAE00111B021AF6B\n\nda5xh91eoDrnn78JUMjZs3nr+hdp/TBEDSbuJcJJbmF6C7Jrqr5lJiS/dLAcqrfc\nBP6MzBaxwTzvqhvflI2EGqPyhIXsOI1UsBqOWWj2WeFPqvbm40sTFuPX0yt/1fH4\nOtlcWHl8nJea3DUQahgimEoYeSfHar6u1quFi778eVR96/3emqe34mKsNa/iLEVi\nyOi/Uww+gjPJRlUHmE9fy6Rcg8x9ixsO03R1hu7CIx41xxNhgQhDrkH7f4VQceGT\nWyh3IyyzHRnhIJ5QxgKCZGsQzIOol2qQ2P/H8nGo9Ksv6i4GEFdF3Ia6v6yyFKRw\n39GDR+ugH8yBY33uQ1NmCxO4KHn/B61XL6sRFjd5UXTSYB5yickBrTAHLROM16xv\nP5+Sc1t1OpIyvnaNJ7wyR81Ja56MQmviH3R+28VvBN10iqeHaaBWv/B63cV57Dag\nyY3n58ZxH7PaxEZBANCpuBKXHnRmlrZo2QrVxp2q9QidsYi/LpgXX/TA42llglqB\n8js9jjG3XO8FRr4Eik05p0vH7Z7EeHXj+mlRBk1H8zCcap0qHeZweYCnhEfL34rf\nBD30nZDjfhqvtpN8TuY1pNZCNADZflmE1HJAqT3ekMrkVs4o23kGfKactnbxS3WA\nSqvPufZQEdPOWyyxGB5Lnmx2l6uFqI2eiPksiZ7UhOgZIag3gKjWbIELmQg1c707\nX9pXNccwS5njC9UbrteTNBidLZK2hSy0h9jvczzIfm7u6X+D4XP/dQlQZOuwCrWw\nuaV0aSrqiPUiPae4loDIBqQSIXeESUFLIDJcEByy4NJRhsNXRkCVkTLN80yy6Snw\nyjFrHh1iDe/mnbs/Ixl2P57dlHhymEV2+1Chzsxif9oM/Y5vdhyaffTmFaNC0lh+\nlmpWJIUyXM6B/IU7I4c0pFYAFDLHLOpb28sAN9IVFFbv9JXm/9+cGYMWANbrjyuh\nTpErr6D4S8y/t4OpMoDadjON2AO+XQkvIoMYS/RLwU9Y1TZx5oH3bLswAyVZLwKu\nOJFkc1sVht1zb4kK639vjA4E3Hnw40Gj59JynGwZLz2ge2bfqsrdtQ2nSXaPI0LF\n4NH2nBxUKZNuYsuBbgMTCP8l2Fca8oHB3gPZVqlhEuV/Bd7TJwGpMXspgCVqwZGz\noQL5JsA87QmktqnnWSCfZAuIKzsy/QPmgf3xgEZODGKJcHM/oEuResRmeb4vbxiK\nXYvJRo8ESVNWIJrBvsTBiLYPG7XBk5MMHGKPGdkc/T7LSKGbqNEl0HJSUzG+x01i\nNVOw7gYZcUhJIIN6ojCbKv0LJsqQwjN3jUxqBhldRu9XXa+Nng6nXs3B9FUvFof4\nvXf8omfdgKekCx2uIc9aE1Y4uSI43TxOatU71uo2UV12z5Sd4NFWk+SyRK2muNZT\noz0kzxFl2wvH/p//MueGqAIxeJA9or2maefY4VvCnlIQvsA6FWk+6sAXywD78TSf\nWA9xHdBhzYnlm+1g4nlNP4dwz/SRb+2sWZm+IwbfOBlubLJDTRyrusxigZyRB+RN\nGEQCr99gNsBoDtn4rQmY/E7Wm3Br1/jlI5PHdl9rIFHjw8SIn/6Faw==\n-----END RSA PRIVATE KEY-----";

        //     var result = await client.SshKey.CreateAsync(organizationName, request);
        //     Assert.NotNull(result);
        //     Assert.Equal(keyName, result.Data.Attributes.Name);

        //     var showResult = await client.SshKey.ShowAsync(result.Data.Id);
        //     Assert.NotNull(showResult);
        //     Assert.Equal(result.Data.Id, showResult.Data.Id);
        // }

        // [Fact]
        // public async Task ListSshKey()
        // {
        //     var organizationName = configuration["organizationName"];

        //     var httpClient = new HttpClient();
        //     var config = new TfeConfig(configuration["teamToken"], httpClient);

        //     var client = new TfeClient(config);

        //     var request = new SshKeyRequest();
        //     var keyName = "test-sshkey-3";
        //     request.Data.Attributes.Name = keyName;
        //     request.Data.Attributes.Value = "-----BEGIN RSA PRIVATE KEY-----\nProc-Type: 4,ENCRYPTED\nDEK-Info: DES-EDE3-CBC,AAE00111B021AF6B\n\nda5xh91eoDrnn78JUMjZs3nr+hdp/TBEDSbuJcJJbmF6C7Jrqr5lJiS/dLAcqrfc\nBP6MzBaxwTzvqhvflI2EGqPyhIXsOI1UsBqOWWj2WeFPqvbm40sTFuPX0yt/1fH4\nOtlcWHl8nJea3DUQahgimEoYeSfHar6u1quFi778eVR96/3emqe34mKsNa/iLEVi\nyOi/Uww+gjPJRlUHmE9fy6Rcg8x9ixsO03R1hu7CIx41xxNhgQhDrkH7f4VQceGT\nWyh3IyyzHRnhIJ5QxgKCZGsQzIOol2qQ2P/H8nGo9Ksv6i4GEFdF3Ia6v6yyFKRw\n39GDR+ugH8yBY33uQ1NmCxO4KHn/B61XL6sRFjd5UXTSYB5yickBrTAHLROM16xv\nP5+Sc1t1OpIyvnaNJ7wyR81Ja56MQmviH3R+28VvBN10iqeHaaBWv/B63cV57Dag\nyY3n58ZxH7PaxEZBANCpuBKXHnRmlrZo2QrVxp2q9QidsYi/LpgXX/TA42llglqB\n8js9jjG3XO8FRr4Eik05p0vH7Z7EeHXj+mlRBk1H8zCcap0qHeZweYCnhEfL34rf\nBD30nZDjfhqvtpN8TuY1pNZCNADZflmE1HJAqT3ekMrkVs4o23kGfKactnbxS3WA\nSqvPufZQEdPOWyyxGB5Lnmx2l6uFqI2eiPksiZ7UhOgZIag3gKjWbIELmQg1c707\nX9pXNccwS5njC9UbrteTNBidLZK2hSy0h9jvczzIfm7u6X+D4XP/dQlQZOuwCrWw\nuaV0aSrqiPUiPae4loDIBqQSIXeESUFLIDJcEByy4NJRhsNXRkCVkTLN80yy6Snw\nyjFrHh1iDe/mnbs/Ixl2P57dlHhymEV2+1Chzsxif9oM/Y5vdhyaffTmFaNC0lh+\nlmpWJIUyXM6B/IU7I4c0pFYAFDLHLOpb28sAN9IVFFbv9JXm/9+cGYMWANbrjyuh\nTpErr6D4S8y/t4OpMoDadjON2AO+XQkvIoMYS/RLwU9Y1TZx5oH3bLswAyVZLwKu\nOJFkc1sVht1zb4kK639vjA4E3Hnw40Gj59JynGwZLz2ge2bfqsrdtQ2nSXaPI0LF\n4NH2nBxUKZNuYsuBbgMTCP8l2Fca8oHB3gPZVqlhEuV/Bd7TJwGpMXspgCVqwZGz\noQL5JsA87QmktqnnWSCfZAuIKzsy/QPmgf3xgEZODGKJcHM/oEuResRmeb4vbxiK\nXYvJRo8ESVNWIJrBvsTBiLYPG7XBk5MMHGKPGdkc/T7LSKGbqNEl0HJSUzG+x01i\nNVOw7gYZcUhJIIN6ojCbKv0LJsqQwjN3jUxqBhldRu9XXa+Nng6nXs3B9FUvFof4\nvXf8omfdgKekCx2uIc9aE1Y4uSI43TxOatU71uo2UV12z5Sd4NFWk+SyRK2muNZT\noz0kzxFl2wvH/p//MueGqAIxeJA9or2maefY4VvCnlIQvsA6FWk+6sAXywD78TSf\nWA9xHdBhzYnlm+1g4nlNP4dwz/SRb+2sWZm+IwbfOBlubLJDTRyrusxigZyRB+RN\nGEQCr99gNsBoDtn4rQmY/E7Wm3Br1/jlI5PHdl9rIFHjw8SIn/6Faw==\n-----END RSA PRIVATE KEY-----";

        //     var result = await client.SshKey.CreateAsync(organizationName, request);
        //     Assert.NotNull(result);
        //     Assert.Equal(keyName, result.Data.Attributes.Name);

        //     var showResult = await client.SshKey.ListAsync(organizationName);
        //     Assert.NotNull(showResult);
        //     Assert.Equal(result.Data.Id, showResult.Data[0].Id);
        // }
    }
}