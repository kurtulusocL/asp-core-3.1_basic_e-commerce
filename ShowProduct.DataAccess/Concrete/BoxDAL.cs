using Microsoft.AspNetCore.Http;
using ShowProduct.Core.CrossCuttingConcert.Extensions.CustomExtensions;
using ShowProduct.Core.DataAccess.EntityFramework;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.DataAccess.Concrete.EntityFramework.Context;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Concrete
{
    public class BoxDAL : EntityRepositoryBase<Product, ApplicationDbContext>, IBoxDAL
    {
        IHttpContextAccessor _httpContextAccessor;
        public BoxDAL(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void AddBox(Product entity)
        {
            var productList = _httpContextAccessor.HttpContext.Session.GetObject<List<Product>>("box");
            if (productList == null)
            {
                productList = new List<Product>();
                productList.Add(entity);
            }
            else
            {
                productList.Add(entity);
            }
            _httpContextAccessor.HttpContext.Session.SetObject("box", productList);
        }

        public void DeleteBox(Product entity)
        {
            var productList = _httpContextAccessor.HttpContext.Session.GetObject<List<Product>>("box");
            productList.Remove(entity);
            _httpContextAccessor.HttpContext.Session.SetObject("box", productList);
        }

        public void EmptyBox()
        {
            _httpContextAccessor.HttpContext.Session.Remove("box");
        }

        public List<Product> BoxProductList()
        {
            return _httpContextAccessor.HttpContext.Session.GetObject<List<Product>>("box");
        }
    }
}
