using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaGit.Web.Startup))]
namespace PruebaGit.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
