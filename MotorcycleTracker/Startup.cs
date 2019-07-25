using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotorcycleTracker.Startup))]
namespace MotorcycleTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
