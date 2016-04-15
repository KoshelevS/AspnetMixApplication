using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspnetMixApplication.Startup))]
namespace AspnetMixApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
