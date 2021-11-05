using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class TagManager : ITagService
    {
        private readonly ITagDAL _tagDAL;
        public TagManager(ITagDAL tagDAL)
        {
            _tagDAL = tagDAL;
        }
        public void Create(Tag entity)
        {
            _tagDAL.Add(entity);
        }

        public void Delete(Tag entity)
        {
            _tagDAL.Delete(entity);
        }

        public List<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetAllProductById(int? id)
        {
            return _tagDAL.GetAllProductById(id);
        }

        public List<Tag> GetAllProductByIdWithoutParameter(int? id)
        {
            return _tagDAL.GetAllProductByIdWithoutParameter(id);
        }

        public List<Tag> GetAllTagInclude()
        {
            return _tagDAL.GetAllTagInclude();
        }

        public List<Tag> GetAllTagIncludeWithoutParameter()
        {
            return _tagDAL.GetAllTagIncludeWithoutParameter();
        }

        public Tag GetById(int? id)
        {
            return _tagDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _tagDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _tagDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _tagDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _tagDAL.SetNotDeleted(id);
        }

        public void Update(Tag entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _tagDAL.Update(entity);
        }
    }
}
