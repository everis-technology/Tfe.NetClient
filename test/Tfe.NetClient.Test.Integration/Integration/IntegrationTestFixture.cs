namespace Tfe.NetClient
{
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// IntegrationTestFixture
    /// </summary>
    public class IntegrationTestFixture
    {
        /// <summary>
        /// Configuration
        /// </summary>
        /// <value></value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// IntegrationTestFixture
        /// </summary>
        public IntegrationTestFixture()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .AddUserSecrets<IntegrationTestFixture>()
                .Build();
        }
    }
}