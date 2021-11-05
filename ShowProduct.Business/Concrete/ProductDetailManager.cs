using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class ProductDetailManager : IProductDetailService
    {
        private readonly IProductDetailDAL _productDetailDAL;
        public ProductDetailManager(IProductDetailDAL productDetailDAL)
        {
            _productDetailDAL = productDetailDAL;
        }
        public void Create(ProductDetail entity)
        {
            _productDetailDAL.Add(entity);
        }

        public void Delete(ProductDetail entity)
        {
            _productDetailDAL.Delete(entity);
        }

        public List<ProductDetail> GetAll()
        {
            return _productDetailDAL.GetAll();
        }

        public List<ProductDetail> GetAllProductById(int? id)
        {
            return _productDetailDAL.GetAllProductById(id);
        }

        public List<ProductDetail> GetAllProductDetailInclude()
        {
            return _productDetailDAL.GetAllProductDetailInclude();
        }

        public List<ProductDetail> GetAllProductDetailIncludeWithoutParameter()
        {
            return _productDetailDAL.GetAllProductDetailIncludeWithoutParameter();
        }

        public ProductDetail GetById(int? id)
        {
            return _productDetailDAL.Get(i => i.Id == id);
        }

        public ProductDetail GetProductById(int? id)
        {
            return _productDetailDAL.GetProductById(id);
        }

        public void SetActive(int id)
        {
            _productDetailDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _productDetailDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _productDetailDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _productDetailDAL.SetNotDeleted(id);
        }

        public void Update(ProductDetail entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _productDetailDAL.Update(entity);
        }
    }
}
