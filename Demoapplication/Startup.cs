using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demoapplication.Startup))]
namespace Demoapplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
