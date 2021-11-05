using ShowProduct.Core.DataAccess;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Abstract
{
    public interface ISubcategoryDAL : IEntityRepository<Subcategory>
    {
        List<Subcategory> GetAllSubcategoryInclude();
        List<Subcategory> GetAllSubcategoryIncludeWithoutParameter();
        List<Subcategory> GetAllCategoryById(int? id);
        List<Subcategory> GetAllCategoryByIdWithoutParameter(int? id);
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
    }
}
