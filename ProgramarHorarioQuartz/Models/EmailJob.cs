using Quartz;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ProgramarHorarioQuartz.Models
{
    public class EmailJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From =
                new MailAddress(ConfigurationManager.AppSettings["FromMail"]);
                mailMessage.Subject = "SchedulerEmail";
                mailMessage.Body = "Test Body SchedulerEmail";
                mailMessage.IsBodyHtml = true;
                mailMessage.To.Add(new MailAddress("david.zambrano10@gmail.com"));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings["Host"];
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = ConfigurationManager.AppSettings["FromMail"];
                NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
            }
        }

    }
}