using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class PictureManager : IPictureService
    {
        private readonly IPictureDAL _pictureDAL;
        public PictureManager(IPictureDAL pictureDAL)
        {
            _pictureDAL = pictureDAL;
        }
        public void Create(Picture entity)
        {
            _pictureDAL.Add(entity);
        }

        public void Delete(Picture entity)
        {
            _pictureDAL.Delete(entity);
        }

        public List<Picture> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Picture> GetAllPictureInclude()
        {
            return _pictureDAL.GetAllPictureInclude();
        }

        public List<Picture> GetAllPictureIncludeWithoutParameter()
        {
            return _pictureDAL.GetAllPictureIncludeWithoutParameter();
        }

        public List<Picture> GetAllProductById(int? id)
        {
            return _pictureDAL.GetAllProductById(id);
        }

        public List<Picture> GetAllProductPicture(int? id)
        {
            return _pictureDAL.GetAllProductPicture(id);
        }

        public Picture GetById(int? id)
        {
            return _pictureDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _pictureDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _pictureDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _pictureDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _pictureDAL.SetNotDeleted(id);
        }

        public void Update(Picture entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _pictureDAL.Update(entity);
        }
    }
}
