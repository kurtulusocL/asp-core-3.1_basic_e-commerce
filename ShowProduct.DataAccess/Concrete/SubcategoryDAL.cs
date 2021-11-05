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
    public class SubcategoryDAL : EntityRepositoryBase<Subcategory, ApplicationDbContext>, ISubcategoryDAL
    {
        public List<Subcategory> GetAllCategoryById(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Subcategory>().Include(i => i.Category).Include(i => i.Products).Where(i => i.IsConfirmed == true && i.IsDeleted == false && i.CategoryId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }
      
        public List<Subcategory> GetAllCategoryByIdWithoutParameter(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Subcategory>().Include(i => i.Category).Include(i => i.Products).Where(i => i.CategoryId == id).OrderByDescending(i => i.Products.Count()).ToList();
            }
        }

        public List<Subcategory> GetAllSubcategoryInclude()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Subcategory>().Include(i => i.Category).Include(i => i.Products).Where(i => i.IsConfirmed == true && i.IsDeleted == false /*&& i.Products.Count() > 0*/).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Subcategory> GetAllSubcategoryIncludeWithoutParameter()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Subcategory>().Include(i => i.Category).Include(i => i.Products).OrderByDescending(i => i.Products.Count()).ToList();
            }
        }

        public void SetActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Subcategory>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Subcategory>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Subcategory>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Subcategory>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                deleted.LastOperationDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }
    }
}
