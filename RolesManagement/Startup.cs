using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RolesManagement.Startup))]
namespace RolesManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
