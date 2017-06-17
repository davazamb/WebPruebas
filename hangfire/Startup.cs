using Hangfire;
using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(hangfire.Startup))]
namespace hangfire
{
    public partial class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    ConfigureAuth(app);
        //}
        public void Configuration(IAppBuilder app)
        {
            //GlobalConfiguration.Configuration
            //    .UseSqlServerStorage("DefaultConnection");

            //app.UseHangfireDashboard();
            //app.UseHangfireServer();


            ConfigureAuth(app);

            GlobalConfiguration.Configuration

                .UseSqlServerStorage("DefaultConnection");

            BackgroundJob.Enqueue(() => Console.WriteLine("Getting Started with HangFire!"));

            BackgroundJob.Schedule(() => Console.WriteLine("This background job would execute after a delay."), TimeSpan.FromMilliseconds(1000));

            RecurringJob.AddOrUpdate(() => Console.WriteLine("This job will execute once in every minute"), Cron.Minutely);
            app.UseHangfireDashboard();

            app.UseHangfireServer();
        }
    }
}
