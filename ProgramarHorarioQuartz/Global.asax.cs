using ProgramarHorarioQuartz.Models;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProgramarHorarioQuartz
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IJobDetail emailJob = JobBuilder.Create<EmailJob>()
              .WithIdentity("job1")
              .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithDailyTimeIntervalSchedule
                  (s =>
                     s.WithIntervalInSeconds(30)
                    .OnEveryDay()
                  )
                 .ForJob(emailJob)
                 .WithIdentity("trigger1")
                 .StartNow()
                 .WithCronSchedule("0 0/1 * * * ?") // Time : Every 1 Minutes job execute
                 .Build();

            ISchedulerFactory sf = new StdSchedulerFactory();
            IScheduler sc = sf.GetScheduler();
            sc.ScheduleJob(emailJob, trigger);
            sc.Start();
        }
    }
}
