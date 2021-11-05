using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;
        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }
        public void Create(About entity)
        {
            _aboutDAL.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutDAL.Delete(entity);
        }

        public List<About> GetAll()
        {
            return _aboutDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<About> GetAllWithoutParameter()
        {
            return _aboutDAL.GetAll();
        }

        public About GetById(int? id)
        {
            return _aboutDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _aboutDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _aboutDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _aboutDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _aboutDAL.SetNotDeleted(id);
        }

        public void Update(About entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _aboutDAL.Update(entity);
        }
    }
}
