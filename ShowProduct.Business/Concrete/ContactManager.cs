using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _contactDAL;
        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }
        public void Create(Contact entity)
        {
            _contactDAL.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDAL.Delete(entity);
        }

        public List<Contact> GetAll()
        {
            return _contactDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<Contact> GetAllWithoutParameter()
        {
            return _contactDAL.GetAll();
        }

        public Contact GetById(int? id)
        {
            return _contactDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _contactDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _contactDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _contactDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _contactDAL.SetNotDeleted(id);
        }

        public void Update(Contact entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _contactDAL.Update(entity);
        }
    }
}
