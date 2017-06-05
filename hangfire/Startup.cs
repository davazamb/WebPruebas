using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hangfire.Startup))]
namespace hangfire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
