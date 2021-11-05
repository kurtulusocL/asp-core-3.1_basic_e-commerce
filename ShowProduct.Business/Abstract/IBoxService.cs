using ShowProduct.Business.Abstract.GenericBusinessServices;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Abstract
{
    public interface IBoxService : IEntityBusinessService<Product>
    {
        void AddBox(Product entity);
        void DeleteBox(Product entity);
        List<Product> BoxProductList();
        void EmptyBox();
    }
}
