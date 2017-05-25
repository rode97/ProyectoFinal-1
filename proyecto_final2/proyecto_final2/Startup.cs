using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyecto_final2.Startup))]
namespace proyecto_final2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
