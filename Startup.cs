using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebS5.Startup))]
namespace WebS5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
