using ShowProduct.Business.Abstract;
using ShowProduct.DataAccess.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDAL _reportDAL;
        public ReportManager(IReportDAL reportDAL)
        {
            _reportDAL = reportDAL;
        }
        public void Create(Report entity)
        {
            _reportDAL.Add(entity);
        }

        public void Delete(Report entity)
        {
            _reportDAL.Delete(entity);
        }

        public List<Report> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Report> GetAllReportById(int? id)
        {
            return _reportDAL.GetAllReportById(id);
        }

        public List<Report> GetAllReportInclude()
        {
            return _reportDAL.GetAllReportInclude();
        }

        public List<Report> GetAllReportIncludeWithoutParameter()
        {
            return _reportDAL.GetAllReportIncludeWithoutParameter();
        }

        public Report GetById(int? id)
        {
            return _reportDAL.Get(i => i.Id == id);
        }

        public void SetActive(int id)
        {
            _reportDAL.SetActive(id);
        }

        public void SetDeActive(int id)
        {
            _reportDAL.SetDeActive(id);
        }

        public void SetDeleted(int id)
        {
            _reportDAL.SetDeleted(id);
        }

        public void SetFixed(int id)
        {
            _reportDAL.SetFixed(id);
        }

        public void SetNotDeleted(int id)
        {
            _reportDAL.SetNotDeleted(id);
        }

        public void SetNotFixed(int id)
        {
            _reportDAL.SetNotFixed(id);
        }

        public void Update(Report entity)
        {
            entity.UpdatedDate = DateTime.Now.ToLocalTime();
            _reportDAL.Update(entity);
        }
    }
}
