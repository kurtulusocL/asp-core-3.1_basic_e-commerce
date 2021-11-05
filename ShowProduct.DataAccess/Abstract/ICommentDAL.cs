using ShowProduct.Core.DataAccess;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Abstract
{
    public interface ICommentDAL : IEntityRepository<Comment>
    {
        List<Comment> GetAllCommentInclude();
        List<Comment> GetAllCommentIncludeWithoutParameter();
        List<Comment> GetAllProductById(int? id);
        Comment HitRead(int? id);
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
    }
}
