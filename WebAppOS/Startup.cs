using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppOS.Startup))]
namespace WebAppOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
