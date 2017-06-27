using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarieCurie.Web.Startup))]
namespace MarieCurie.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
