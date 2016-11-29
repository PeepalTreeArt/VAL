using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValsuraERP.Startup))]
namespace ValsuraERP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
