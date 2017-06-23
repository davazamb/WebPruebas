using IdentityManager;
using IdentityManager.AspNetIdentity;
using IdentityManager.Configuration;
using IdentityManager.Core.Logging;
using IdentityManager.Logging;
using IdentityManagerMVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityManagerMVC.Startup))]
namespace IdentityManagerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            LogProvider.SetCurrentLogProvider(new TraceSourceLogProvider());

            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies",
                //LoginPath = new PathString("/IdentityManager/Logins")

            });

            app.Map("/idm", idm => 
            {
                var factory = new IdentityManagerServiceFactory();
                factory.IdentityManagerService = new Registration<IIdentityManagerService, ApplicationIdentityManagerService>();
                factory.Register(new Registration<ApplicationUserManager>());
                factory.Register(new Registration<ApplicationUserStore>());
                factory.Register(new Registration<ApplicationRoleStore>());
                factory.Register(new Registration<AplicationRoleManager>());
                //factory.Register(new Registration<ApplicationDbContext>(resolver => new ApplicationDbContext("Default") ));
                factory.Register(new Registration<ApplicationDbContext>());


                idm.UseIdentityManager(new IdentityManagerOptions {
                    Factory = factory,
                    //SecurityConfiguration = new HostSecurityConfiguration()
                    //{
                    //    HostAuthenticationType="Cookies",
                    //    NameClaimType = "name",
                    //    RoleClaimType = "role",
                    //    AdminRoleName = "Admin",
                    //}
                });
            });
        }
    }



    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext ctx)  : base(ctx)
        {

        }
    }

    public class ApplicationRoleStore : RoleStore<IdentityRole>
    {
        public ApplicationRoleStore(ApplicationDbContext ctx)  : base(ctx)
        {

        }
    }

    public class AplicationRoleManager : RoleManager<IdentityRole>
    {
        public  AplicationRoleManager(ApplicationRoleStore roleStore) : base(roleStore)
        {
        }
    }
    public class ApplicationIdentityManagerService : AspNetIdentityManagerService<ApplicationUser, string, IdentityRole, string>
    {
        public ApplicationIdentityManagerService(ApplicationUserManager userMgr, AplicationRoleManager roleMgr) : base(userMgr, roleMgr)
        {

        }


    }
}
