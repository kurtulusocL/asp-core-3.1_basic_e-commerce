using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class SendMailManager : ISendMailService
    {
        private readonly ISendMailDAL _sendMailDAL;
        public SendMailManager(ISendMailDAL sendMailDAL)
        {
            _sendMailDAL = sendMailDAL;
        }
        public void Create(SendMail entity)
        {
            _sendMailDAL.Send(entity);
        }

        public void Delete(SendMail entity)
        {
            _sendMailDAL.Delete(entity);
        }

        public List<SendMail> GetAll()
        {
            return _sendMailDAL.GetAll(i => i.IsConfirmed == true && i.IsDeleted == false);
        }

        public List<SendMail> GetAllWithoutParameter()
        {
            return _sendMailDAL.GetAll();
        }

        public SendMail GetById(int? id)
        {
            return _sendMailDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _sendMailDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _sendMailDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _sendMailDAL.SetDeleted(id);
        }

        public void SetNotDeleted(int id)
        {
            _sendMailDAL.SetNotDeleted(id);
        }

        public void Update(SendMail entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _sendMailDAL.Update(entity);
        }
    }
}
