using Microsoft.AspNetCore.Http;
using ShowProduct.Business.Abstract;
using ShowProduct.Core.CrossCuttingConcert.Extensions.CustomExtensions;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class BoxManager : IBoxService
    {
        IBoxDAL _boxDAL;
        public BoxManager(IBoxDAL boxDAL)
        {
            _boxDAL = boxDAL;
        }

        public void AddBox(Product entity)
        {
            _boxDAL.AddBox(entity);
        }

        public List<Product> BoxProductList()
        {
            return _boxDAL.BoxProductList();
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteBox(Product entity)
        {
            _boxDAL.DeleteBox(entity);
        }

        public void EmptyBox()
        {
            _boxDAL.EmptyBox();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
