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
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public void Create(Product entity)
        {
            _productDAL.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategoryById(int? id)
        {
            return _productDAL.GetAllCategoryById(id);
        }

        public List<Product> GetAllCategoryByIdWithoutParameter(int? id)
        {
            return _productDAL.GetAllCategoryByIdWithoutParameter(id);
        }

        public List<Product> GetAllCommentable()
        {
            return _productDAL.GetAllCommentable();
        }

        public List<Product> GetAllNotCommentable()
        {
            return _productDAL.GetAllNotCommentable();
        }

        public List<Product> GetAllNotSpecialOffer()
        {
            return _productDAL.GetAllSpecialOffer();
        }

        public List<Product> GetAllProductInclude()
        {
            return _productDAL.GetAllProductInclude();
        }

        public List<Product> GetAllProductIncludeWithoutParameter()
        {
            return _productDAL.GetAllProductIncludeWithoutParameter();
        }

        public List<Product> GetAllProductSearch(string key)
        {
            return _productDAL.GetAllProductSearch(key);
        }

        public List<Product> GetAllSpecialOffer()
        {
            return _productDAL.GetAllNotSpecialOffer();
        }

        public List<Product> GetAllSpecialOfferWithoutParameter()
        {
            return _productDAL.GetAllSpecialOfferWithoutParameter();
        }

        public List<Product> GetAllSubcategoryById(int? id)
        {
            return _productDAL.GetAllSubcategoryById(id);
        }

        public List<Product> GetAllSubcategoryByIdWithoutParameter(int? id)
        {
            return _productDAL.GetAllSubcategoryByIdWithoutParameter(id);
        }

        public Product GetById(int? id)
        {
            return _productDAL.Get(i => i.Id == id);
        }

        public Product GetProductById(int? id)
        {
            return _productDAL.GetProductById(id);
        }

        public Product HitRead(int? id)
        {
            return _productDAL.HitRead(id);
        }

        public void SetActive(int id)
        {
            _productDAL.SetActive(id);
        }

        public void SetCommentable(int id)
        {
            _productDAL.SetCommentable(id);
        }

        public void SetDeActive(int id)
        {
            _productDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _productDAL.SetDeleted(id);
        }

        public void SetNotCommentable(int id)
        {
            _productDAL.SetNotCommentable(id);
        }

        public void SetNotDeleted(int id)
        {
            _productDAL.SetNotDeleted(id);
        }

        public void SetNotSpecialOffer(int id)
        {
            _productDAL.SetNotSpecialOffer(id);
        }

        public void SetSpecialOffer(int id)
        {
            _productDAL.SetSpecialOffer(id);
        }

        public void Update(Product entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _productDAL.Update(entity);
        }
    }
}
