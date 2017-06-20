using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SweetAlertWeb.Startup))]
namespace SweetAlertWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
