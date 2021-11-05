using ShowProduct.Business.Abstract;
using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;
using ShowProduct.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userDAL;
        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void Create(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ApplicationUser entity)
        {
            _userDAL.Delete(entity);
        }

        public void Deleted(string id)
        {
            _userDAL.Deleted(id);
        }

        public List<ApplicationUser> GetAll()
        {
            return _userDAL.GetAll(i => i.Title != null);
        }
        public List<ApplicationUser> GetAllUser()
        {
            return _userDAL.GetAll(i => i.Title == "" || i.Title == null);
        }

        public ApplicationUser GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetUserById(string id)
        {
            return _userDAL.GetUserById(id);
        }

        public void SetActive(string id)
        {
            _userDAL.SetActive(id);
        }

        public void SetDeActive(string id)
        {
            _userDAL.SetDeActive(id);
        }

        public void SetNotDeleted(string id)
        {
            _userDAL.SetNotDeleted(id);
        }

        public void Update(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
