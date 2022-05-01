using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicForFreedom.Startup))]
namespace MusicForFreedom
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
