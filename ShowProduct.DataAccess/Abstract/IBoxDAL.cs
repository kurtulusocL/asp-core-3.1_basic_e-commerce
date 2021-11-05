using ShowProduct.Core.DataAccess;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Abstract
{
    public interface IBoxDAL : IEntityRepository<Product>
    {
        void AddBox(Product entity);
        void DeleteBox(Product entity);
        List<Product> BoxProductList();
        void EmptyBox();
    }
}
