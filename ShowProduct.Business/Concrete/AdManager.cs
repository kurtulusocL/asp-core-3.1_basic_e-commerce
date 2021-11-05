using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class AdManager : IAdService
    {
        private readonly IAdDAL _adDAL;
        public AdManager(IAdDAL adDAL)
        {
            _adDAL = adDAL;
        }
        public void Create(Ad entity)
        {
            _adDAL.Add(entity);
        }

        public void Delete(Ad entity)
        {
            _adDAL.Delete(entity);
        }

        public List<Ad> GetAll()
        {
            return _adDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<Ad> GetAllWithoutParameter()
        {
            return _adDAL.GetAll();
        }

        public Ad GetById(int? id)
        {
            return _adDAL.Get(i => i.Id == id);
        }

        public Ad HitRead(int? id)
        {
            return _adDAL.HitRead(id);
        }

        public void SetActive(int id)
        {
            _adDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _adDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _adDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _adDAL.SetNotDeleted(id);
        }

        public void Update(Ad entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _adDAL.Update(entity);
        }
    }
}
