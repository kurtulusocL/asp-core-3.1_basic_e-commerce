using ShowProduct.Business.Abstract.GenericBusinessServices;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShowProduct.Business.Abstract
{
    public interface IReportService : IEntityBusinessService<Report>
    {
        List<Report> GetAllReportInclude();
        List<Report> GetAllReportIncludeWithoutParameter();
        List<Report> GetAllReportById(int? id);
        void SetActive(int id);
        void SetDeActive(int id);
        void SetDeleted(int id);
        void SetNotDeleted(int id);
        void SetFixed(int id);
        void SetNotFixed(int id);
    }
}
