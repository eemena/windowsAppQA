using Microsoft.Extensions.Configuration;

namespace Helpers
{
    public class Common
    {
        private const string appSettingsFilePath = "appsettings.json";
        private static IConfiguration configuration = default!;

        public static IConfiguration Configuration
        {
            get
            {
                if (configuration is null)
                {
                    configuration = new ConfigurationBuilder()
                        .AddJsonFile(appSettingsFilePath)
                        .Build();
                }

                return configuration;
            }
        }
    }
}