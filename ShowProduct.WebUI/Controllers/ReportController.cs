using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_reportService.GetAllReportInclude().ToPagedList(page, 25));
        }
        public IActionResult Product(int? id, int page = 1)
        {
            return View(_reportService.GetAllReportById(id).ToPagedList(page, 20));
        }
        public IActionResult ReportManage(int page = 1)
        {
            return View(_reportService.GetAllReportIncludeWithoutParameter().ToPagedList(page, 35));
        }
        public IActionResult Detail(int id)
        {
            return View(_reportService.GetById(id));
        }
        public IActionResult Delete(int? id)
        {
            var deleteReport = _reportService.GetById(id);
            if (deleteReport != null)
            {
                _reportService.Delete(deleteReport);
                return RedirectToAction(nameof(ReportManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult SetFixed(int id)
        {
            _reportService.SetFixed(id);
            return RedirectToAction(nameof(ReportManage));
        }
        public IActionResult SetNotFixed(int id)
        {
            _reportService.SetNotFixed(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Active(int id)
        {
            _reportService.SetActive(id);
            return RedirectToAction(nameof(ReportManage));
        }
        public IActionResult DeActive(int id)
        {
            _reportService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _reportService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _reportService.SetNotDeleted(id);
            return RedirectToAction(nameof(ReportManage));
        }
    }
}
