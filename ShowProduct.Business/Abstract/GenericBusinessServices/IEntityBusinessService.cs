using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Abstract.GenericBusinessServices
{
    public interface IEntityBusinessService<T>
    {
        List<T> GetAll();
        T GetById(int? id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
