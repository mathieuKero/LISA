using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using WebServiceLISA.Models;

namespace WebServiceLISA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IWebHostBuilder builder = WebHost.CreateDefaultBuilder(args);
            builder.UseStartup<Startup>();
            IWebHost host = builder.Build();

            return host;
        }

    }
}
