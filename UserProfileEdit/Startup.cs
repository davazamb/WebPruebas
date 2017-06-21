using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserProfileEdit.Startup))]
namespace UserProfileEdit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
