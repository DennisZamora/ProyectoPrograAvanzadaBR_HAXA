using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BR_HAXA_FE
{
    public class Program
    {

        public static string baseurl = "http://localhost:49597";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
