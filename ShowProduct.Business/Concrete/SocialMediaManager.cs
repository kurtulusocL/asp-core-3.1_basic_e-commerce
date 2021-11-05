using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDAL _socialMediaDAL;
        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }
        public void Create(SocialMedia entity)
        {
            _socialMediaDAL.Add(entity);
        }

        public void Delete(SocialMedia entity)
        {
            _socialMediaDAL.Delete(entity);
        }

        public List<SocialMedia> GetAll()
        {
            return _socialMediaDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<SocialMedia> GetAllWithoutParameter()
        {
            return _socialMediaDAL.GetAll();
        }

        public SocialMedia GetById(int? id)
        {
            return _socialMediaDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _socialMediaDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _socialMediaDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _socialMediaDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _socialMediaDAL.SetNotDeleted(id);
        }

        public void Update(SocialMedia entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _socialMediaDAL.Update(entity);
        }
    }
}
