using ShowProduct.Business.Abstract.GenericBusinessServices;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Abstract
{
    public interface ILocationService : IEntityBusinessService<Location>
    {
        List<Location> GetAllWithoutParameter();
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
    }
}
