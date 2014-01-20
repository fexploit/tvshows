using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Izlemag.Web.Startup))]
namespace Izlemag.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
