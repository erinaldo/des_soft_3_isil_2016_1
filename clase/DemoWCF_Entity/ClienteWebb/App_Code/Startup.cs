using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClienteWebb.Startup))]
namespace ClienteWebb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
