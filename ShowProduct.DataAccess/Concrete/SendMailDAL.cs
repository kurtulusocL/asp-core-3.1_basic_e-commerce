using Microsoft.EntityFrameworkCore;
using ShowProduct.Core.DataAccess.EntityFramework;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.DataAccess.Concrete.EntityFramework.Context;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Concrete
{
    public class SendMailDAL : EntityRepositoryBase<SendMail, ApplicationDbContext>, ISendMailDAL
    {
        public void Send(SendMail entity)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(entity.SenderEMail, "Kurtuluş Öcal");
                mail.Priority = MailPriority.High;
                mail.Subject = entity.Subject;
                mail.To.Add(new MailAddress(entity.RecieverEMail, ""));
                mail.Body = entity.Message;
                mail.IsBodyHtml = true;

                NetworkCredential enter = new NetworkCredential(entity.SenderEMail, "your password");
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = enter;
                client.Send(mail);

                context.SendMails.Add(entity);
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void SetActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<SendMail>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<SendMail>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<SendMail>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<SendMail>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                deleted.LastOperationDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }
    }
}
