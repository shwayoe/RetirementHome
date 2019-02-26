using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetirementHome.Startup))]
namespace RetirementHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
