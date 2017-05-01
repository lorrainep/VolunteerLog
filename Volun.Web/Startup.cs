using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Volun.Web.Startup))]
namespace Volun.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
