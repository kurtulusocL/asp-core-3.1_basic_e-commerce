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
    public class ReportDAL : EntityRepositoryBase<Report, ApplicationDbContext>, IReportDAL
    {
        public List<Report> GetAllReportById(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Report>().Include(i => i.Product).Where(i => i.ProductId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Report> GetAllReportInclude()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Report>().Include(i => i.Product).Where(i => i.IsConfirmed == true && i.IsDeleted == false).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Report> GetAllReportIncludeWithoutParameter()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Report>().Include(i => i.Product).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public void SetActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Report>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Report>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Report>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetFixed(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var fix = context.Set<Report>().Where(i => i.Id == id).FirstOrDefault();
                fix.IsFixed = true;
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Report>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotFixed(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var fix = context.Set<Report>().Where(i => i.Id == id).FirstOrDefault();
                fix.IsFixed = false;
                context.SaveChanges();
            }
        }
    }
}
