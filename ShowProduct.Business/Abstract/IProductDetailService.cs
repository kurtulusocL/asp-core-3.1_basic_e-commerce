using ShowProduct.Business.Abstract.GenericBusinessServices;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Abstract
{
    public interface IProductDetailService : IEntityBusinessService<ProductDetail>
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
