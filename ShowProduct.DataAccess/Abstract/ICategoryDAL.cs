using ShowProduct.Core.DataAccess;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {
        List<Category> GetAllCategoryInclude();
        List<Category> GetAllCategoryIncludeWithoutParameter();
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
    }
}
