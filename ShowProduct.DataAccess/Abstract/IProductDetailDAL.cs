using ShowProduct.Core.DataAccess;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Abstract
{
    public interface IProductDetailDAL : IEntityRepository<ProductDetail>
    {
        List<ProductDetail> GetAllProductDetailInclude();
        List<ProductDetail> GetAllProductDetailIncludeWithoutParameter();
        List<ProductDetail> GetAllProductById(int? id);
        ProductDetail GetProductById(int? id);
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
    }
}
