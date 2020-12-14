using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(MobileTrade.Web.Areas.Identity.IdentityHostingStartup))]

namespace MobileTrade.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}