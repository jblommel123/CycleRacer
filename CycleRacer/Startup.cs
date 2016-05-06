using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CycleRacer.Startup))]
namespace CycleRacer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
