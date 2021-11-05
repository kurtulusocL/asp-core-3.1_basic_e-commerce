using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class LocationManager : ILocationService
    {
        private readonly ILocationDAL _locationDAL;
        public LocationManager(ILocationDAL locationDAL)
        {
            _locationDAL = locationDAL;
        }
        public void Create(Location entity)
        {
            _locationDAL.Add(entity);
        }

        public void Delete(Location entity)
        {
            _locationDAL.Delete(entity);
        }

        public List<Location> GetAll()
        {
            return _locationDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }
        public List<Location> GetAllWithoutParameter()
        {
            return _locationDAL.GetAll();
        }

        public Location GetById(int? id)
        {
            return _locationDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _locationDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _locationDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _locationDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _locationDAL.SetNotDeleted(id);
        }

        public void Update(Location entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _locationDAL.Update(entity);
        }
    }
}
