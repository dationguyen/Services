using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TFWGService.Startup))]

namespace TFWGService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}