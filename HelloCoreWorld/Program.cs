using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HelloCoreWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
            .UseKestrel(options =>
           {
               //options.Listen(IPAddress.Loopback, 8088, listenOptions =>
               //{
               //    listenOptions.UseHttps("testcertificate.pfx", "testying123");
               //});
           });
    }
}
