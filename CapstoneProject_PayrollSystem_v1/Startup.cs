using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapstoneProject_PayrollSystem_v1.Startup))]
namespace CapstoneProject_PayrollSystem_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
