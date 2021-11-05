using ShowProduct.Business.Abstract.GenericBusinessServices;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Abstract
{
    public interface IProductService : IEntityBusinessService<Product>
    {
        List<Product> GetAllProductInclude();
        List<Product> GetAllProductIncludeWithoutParameter();
        List<Product> GetAllCategoryById(int? id);
        List<Product> GetAllCategoryByIdWithoutParameter(int? id);
        List<Product> GetAllSubcategoryById(int? id);
        List<Product> GetAllSubcategoryByIdWithoutParameter(int? id);
        Product GetProductById(int? id);
        List<Product> GetAllSpecialOffer();
        List<Product> GetAllSpecialOfferWithoutParameter();
        List<Product> GetAllNotSpecialOffer();
        List<Product> GetAllCommentable();
        List<Product> GetAllNotCommentable();
        List<Product> GetAllProductSearch(string key);
        Product HitRead(int? id);
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
        void SetCommentable(int id);
        void SetNotCommentable(int id);
        void SetSpecialOffer(int id);
        void SetNotSpecialOffer(int id);
    }
}
