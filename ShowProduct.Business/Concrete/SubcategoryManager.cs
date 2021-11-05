using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class SubcategoryManager : ISubcategoryService
    {
        private readonly ISubcategoryDAL _subcategoryDAL;
        public SubcategoryManager(ISubcategoryDAL subcategoryDAL)
        {
            _subcategoryDAL = subcategoryDAL;
        }
        public void Create(Subcategory entity)
        {
            _subcategoryDAL.Add(entity);
        }

        public void Delete(Subcategory entity)
        {
            _subcategoryDAL.Delete(entity);
        }

        public List<Subcategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Subcategory> GetAllCategoryById(int? id)
        {
            return _subcategoryDAL.GetAllCategoryById(id);
        }

        public List<Subcategory> GetAllCategoryByIdWithoutParameter(int? id)
        {
            return _subcategoryDAL.GetAllCategoryByIdWithoutParameter(id);
        }

        public List<Subcategory> GetAllSubcategoryInclude()
        {
            return _subcategoryDAL.GetAllSubcategoryInclude();
        }

        public List<Subcategory> GetAllSubcategoryIncludeWithoutParameter()
        {
            return _subcategoryDAL.GetAllSubcategoryIncludeWithoutParameter();
        }

        public Subcategory GetById(int? id)
        {
            return _subcategoryDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _subcategoryDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _subcategoryDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _subcategoryDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _subcategoryDAL.SetNotDeleted(id);
        }

        public void Update(Subcategory entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _subcategoryDAL.Update(entity);
        }
    }
}
