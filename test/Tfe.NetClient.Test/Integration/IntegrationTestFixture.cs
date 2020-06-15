namespace Tfe.NetClient
{
    using Microsoft.Extensions.Configuration;

    public class IntegrationTestFixture
    {
        public IConfiguration Configuration { get; }

        public IntegrationTestFixture()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}