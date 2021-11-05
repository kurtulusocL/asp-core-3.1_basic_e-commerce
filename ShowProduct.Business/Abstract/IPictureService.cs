using ShowProduct.Business.Abstract.GenericBusinessServices;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Abstract
{
    public interface IPictureService : IEntityBusinessService<Picture>
    {
        List<Picture> GetAllPictureInclude();
        List<Picture> GetAllPictureIncludeWithoutParameter();
        List<Picture> GetAllProductById(int? id);
        List<Picture> GetAllProductPicture(int? id);
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
    }
}
