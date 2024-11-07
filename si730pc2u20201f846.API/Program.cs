using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace si730pc2u20201f846.API
{
    /// <summary>
    /// Entry point for the LogisticsPro API application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to start the application.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the host builder for the application.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>IHostBuilder instance to configure the host.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
