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
    public class ProductDAL : EntityRepositoryBase<Product, ApplicationDbContext>, IProductDAL
    {
        public List<Product> GetAllCategoryById(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsConfirmed == true && i.IsDeleted == false && i.CategoryId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllCategoryByIdWithoutParameter(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.CategoryId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllCommentable()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsCommentable == true).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllNotCommentable()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsCommentable == false).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllNotSpecialOffer()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsSpecialOffer == false).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllProductInclude()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsConfirmed == true && i.IsDeleted == false).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllProductIncludeWithoutParameter()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllProductSearch(string key)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsConfirmed == true && i.IsDeleted == false && i.Name.Contains(key) || i.Subtitle.Contains(key)).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllSpecialOffer()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsConfirmed == true && i.IsDeleted == false && i.IsSpecialOffer == true).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllSpecialOfferWithoutParameter()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsSpecialOffer == true).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllSubcategoryById(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.IsConfirmed == true && i.IsDeleted == false && i.SubcategoryId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Product> GetAllSubcategoryByIdWithoutParameter(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.SubcategoryId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public Product GetProductById(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Product>().Include(i => i.Category).Include(i => i.Subcategory).Include(i => i.Comments).Include(i => i.Reports).Include(i => i.Tags).Include(i => i.ProductDetails).Include(i => i.Pictures).Where(i => i.Id == id).FirstOrDefault();
            }
        }

        public Product HitRead(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var hit = context.Set<Product>().Where(i => i.Id == id).SingleOrDefault();
                hit.Hit++;
                context.SaveChanges();
                return hit;
            }
        }

        public void SetActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetCommentable(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var commetable = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                commetable.IsCommentable = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotCommentable(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var commetable = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                commetable.IsCommentable = false;
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotSpecialOffer(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var specialOffer = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                specialOffer.IsSpecialOffer = false;
                context.SaveChanges();
            }
        }

        public void SetSpecialOffer(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var specialOffer = context.Set<Product>().Where(i => i.Id == id).FirstOrDefault();
                specialOffer.IsSpecialOffer = true;
                context.SaveChanges();
            }
        }
    }
}
