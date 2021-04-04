using Tfe.NetClient.Features.ConfigurationVersions;

namespace Tfe.NetClient
{
    using Xunit;
    using System.Threading.Tasks;

    /// <summary>
    /// WorkspaceTest
    /// </summary>
    public class ConfigurationVersionTest
    {
        /// <summary>
        /// ShowConfigurationVersionTest
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task ShowConfigurationVersionTest()
        {
            var configurationVersionId = "cv-1234567890abcdef";
            
            ConfigurationVersionsResponse result = await GetTestClient("ConfigurationVersion/ConfigurationVersions").ConfigurationVersion.ShowConfigurationVersionsAsync(configurationVersionId);

            Assert.NotNull(result);
            Assert.Equal(configurationVersionId, result.Data.Id);
            Assert.Equal("github", result.Data.Attributes.Source);
            Assert.Equal("file1.tf", result.Data.Attributes.ChangedFiles[0]);
            Assert.Equal("ia-1234567890abcdef", result.Data.Relationships.IngressAttributes.RelationshipData.Id);
        }

        /// <summary>
        /// ShowConfigurationVersionTest
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task ShowIngressAttributesTest()
        {
            var configurationVersionId = "ia-1234567890abcdef";

            IngressAttributesResponse result = await GetTestClient("ConfigurationVersion/IngressAttributes").ConfigurationVersion.ShowIngressAttributesAsync(configurationVersionId);

            Assert.NotNull(result);
            Assert.Equal(configurationVersionId, result.Data.Id);
        }

        private TfeClient GetTestClient(string testFile)
        {
            var httpClient = new TestHttpClient()
            {
                Handler = (entry) =>
                {
                    TestHttpClient.SendResponse(testFile, entry);
                }
            };

            var config = new TfeConfig("faketoken", httpClient);

            return new TfeClient(config);
        }
    }
}