using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dream_Planner.Startup))]
namespace Dream_Planner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
