using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgTask2.Startup))]
namespace ProgTask2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
