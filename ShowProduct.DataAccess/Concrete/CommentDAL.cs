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
    public class CommentDAL : EntityRepositoryBase<Comment, ApplicationDbContext>, ICommentDAL
    {
        public List<Comment> GetAllCommentInclude()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Comment>().Include(i => i.Product).Where(i => i.IsConfirmed == true && i.IsDeleted == false).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Comment> GetAllCommentIncludeWithoutParameter()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Comment>().Include(i => i.Product).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public List<Comment> GetAllProductById(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Set<Comment>().Include(i => i.Product).Where(i => i.ProductId == id).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        public Comment HitRead(int? id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var hit = context.Set<Comment>().Where(i => i.Id == id).SingleOrDefault();
                hit.Hit++;
                context.SaveChanges();
                return hit;
            }
        }

        public void SetActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Comment>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = true;
                context.SaveChanges();
            }
        }

        public void SetDeActive(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var active = context.Set<Comment>().Where(i => i.Id == id).FirstOrDefault();
                active.IsConfirmed = false;
                context.SaveChanges();
            }
        }

        public void SetDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Comment>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = true;
                deleted.IsDeletedDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }

        public void SetNotDeleted(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleted = context.Set<Comment>().Where(i => i.Id == id).FirstOrDefault();
                deleted.IsDeleted = false;
                deleted.LastOperationDate = DateTime.Now.ToLocalTime();
                context.SaveChanges();
            }
        }
    }
}
