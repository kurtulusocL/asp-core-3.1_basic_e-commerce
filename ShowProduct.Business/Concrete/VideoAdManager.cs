using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class VideoAdManager : IVideoAdService
    {
        private readonly IVideoAdDAL _videoAdDAL;
        public VideoAdManager(IVideoAdDAL videoAdDAL)
        {
            _videoAdDAL = videoAdDAL;
        }
        public void Create(VideoAd entity)
        {
            _videoAdDAL.Add(entity);
        }

        public void Delete(VideoAd entity)
        {
            _videoAdDAL.Delete(entity);
        }

        public List<VideoAd> GetAll()
        {
            return _videoAdDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<VideoAd> GetAllWithoutParameter()
        {
            return _videoAdDAL.GetAll();
        }

        public VideoAd GetById(int? id)
        {
            return _videoAdDAL.Get(i => i.Id == id);
        }

        public VideoAd HitRead(int? id)
        {
            return _videoAdDAL.HitRead(id);
        }

        public void SetActive(int id)
        {
            _videoAdDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _videoAdDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _videoAdDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _videoAdDAL.SetNotDeleted(id);
        }

        public void Update(VideoAd entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _videoAdDAL.Update(entity);
        }
    }
}
