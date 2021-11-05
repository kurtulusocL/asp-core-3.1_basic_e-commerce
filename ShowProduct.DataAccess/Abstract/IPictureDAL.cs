using ShowProduct.Core.DataAccess;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.DataAccess.Abstract
{
    public interface IPictureDAL : IEntityRepository<Picture>
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
