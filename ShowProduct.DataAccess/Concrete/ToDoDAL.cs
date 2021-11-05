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
    public class ToDoDaL : EntityRepositoryBase<ToDo, ApplicationDbContext>, IToDoDAL
    {
        public void SetActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<ToDo>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<ToDo>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<ToDo>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetFinished(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var finished = context.Set<ToDo>().Where(i => i.Id == id).FirstOrDefault();
                finished.IsFinished = true;
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<ToDo>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotFinished(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var finished = context.Set<ToDo>().Where(i => i.Id == id).FirstOrDefault();
                finished.IsFinished = false;
                context.SaveChanges();
            }
        }
    }
}
