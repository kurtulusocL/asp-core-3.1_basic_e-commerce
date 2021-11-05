using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class ContactMessageManager : IContactMessageService
    {
        private readonly IContactMessageDAL _contactMessageDAL;
        public ContactMessageManager(IContactMessageDAL contactMessageDAL)
        {
            _contactMessageDAL = contactMessageDAL;
        }
        public void Create(ContactMessage entity)
        {
            _contactMessageDAL.Add(entity);
        }

        public void Delete(ContactMessage entity)
        {
            _contactMessageDAL.Delete(entity);
        }

        public List<ContactMessage> GetAll()
        {
            return _contactMessageDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<ContactMessage> GetAllWithoutParameter()
        {
            return _contactMessageDAL.GetAll();
        }

        public ContactMessage GetById(int? id)
        {
            return _contactMessageDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _contactMessageDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _contactMessageDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _contactMessageDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _contactMessageDAL.SetNotDeleted(id);
        }

        public void Update(ContactMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
