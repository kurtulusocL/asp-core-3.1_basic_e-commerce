using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class UserLogManager : IUserLogService
    {
        private readonly IUserLogDAL _userLogDAL;
        public UserLogManager(IUserLogDAL userLogDAL)
        {
            _userLogDAL = userLogDAL;
        }
        public void Create(UserLog entity)
        {
            _userLogDAL.Add(entity);
        }

        public void Delete(UserLog entity)
        {
            _userLogDAL.Delete(entity);
        }

        public List<UserLog> GetAll()
        {
            return _userLogDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<UserLog> GetAllWithoutParameter()
        {
            return _userLogDAL.GetAll();
        }

        public UserLog GetById(int? id)
        {
            return _userLogDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _userLogDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _userLogDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _userLogDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _userLogDAL.SetNotDeleted(id);
        }

        public void Update(UserLog entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _userLogDAL.Update(entity);
        }
    }
}
