using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;
using ShowProduct.Core.DataAccess.EntityFramework;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowProduct.DataAccess.Concrete
{
    public class UserDAL : EntityRepositoryBase<ApplicationUser, ApplicationDbContext>, IUserDAL
    {
        public void Deleted(string id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<ApplicationUser>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                context.SaveChanges();
            }
        }

        public ApplicationUser GetUserById(string id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<ApplicationUser>().Find(id);
            }
        }

        public void SetActive(string id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<ApplicationUser>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(string id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<ApplicationUser>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(string id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<ApplicationUser>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                context.SaveChanges();
            }
        }
    }
}
