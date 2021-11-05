using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDAL _commentDAL;
        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void Create(Comment entity)
        {
            _commentDAL.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDAL.Delete(entity);
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllCommentInclude()
        {
            return _commentDAL.GetAllCommentInclude();
        }

        public List<Comment> GetAllCommentIncludeWithoutParameter()
        {
            return _commentDAL.GetAllCommentIncludeWithoutParameter();
        }

        public List<Comment> GetAllProductById(int? id)
        {
            return _commentDAL.GetAllProductById(id);
        }

        public Comment GetById(int? id)
        {
            return _commentDAL.Get(i => i.Id == id);
        }

        public Comment HitRead(int? id)
        {
            return _commentDAL.HitRead(id);
        }

        public void SetActive(int id)
        {
            _commentDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _commentDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _commentDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _commentDAL.SetNotDeleted(id);
        }

        public void Update(Comment entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _commentDAL.Update(entity);
        }
    }
}
