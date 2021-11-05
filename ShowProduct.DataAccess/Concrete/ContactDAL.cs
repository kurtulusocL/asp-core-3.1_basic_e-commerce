using Microsoft.EntityFrameworkCore;
using ShowProduct.Core.DataAccess.EntityFramework;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.DataAccess.Concrete.EntityFramework.Context;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Concrete
{
    public class ContactDAL : EntityRepositoryBase<Contact, ApplicationDbContext>, IContactDAL
    {
        public void SetActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Contact>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Contact>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Contact>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Contact>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                deleted.LastOperationDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }
    }
}
