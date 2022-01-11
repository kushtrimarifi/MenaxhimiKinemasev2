using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenaxhimiKinemasev2.Startup))]
namespace MenaxhimiKinemasev2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
