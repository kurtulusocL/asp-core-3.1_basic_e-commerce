using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Create(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategoryInclude()
        {
            return _categoryDAL.GetAllCategoryInclude();
        }

        public List<Category> GetAllCategoryIncludeWithoutParameter()
        {
            return _categoryDAL.GetAllCategoryIncludeWithoutParameter();
        }

        public Category GetById(int? id)
        {
            return _categoryDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _categoryDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _categoryDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _categoryDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _categoryDAL.SetNotDeleted(id);
        }

        public void Update(Category entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _categoryDAL.Update(entity);
        }
    }
}
