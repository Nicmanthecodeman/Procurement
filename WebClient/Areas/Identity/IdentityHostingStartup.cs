using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebClient.Areas.Identity.IdentityHostingStartup))]
namespace WebClient.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}