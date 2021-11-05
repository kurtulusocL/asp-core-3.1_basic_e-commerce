using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    public class SendMailController : Controller
    {
        private readonly ISendMailService _mailService;
        public SendMailController(ISendMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_mailService.GetAll().ToPagedList(page, 15));
        }
        public IActionResult MailManage(int page = 1)
        {
            return View(_mailService.GetAllWithoutParameter().ToPagedList(page, 25));
        }
        public IActionResult Detail(int? id)
        {
            return View(_mailService.GetById(id));
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SendMail model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _mailService.Create(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteMail = _mailService.GetById(id);
            if (deleteMail != null)
            {
                _mailService.Delete(deleteMail);
                return RedirectToAction(nameof(MailManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _mailService.SetActive(id);
            return RedirectToAction(nameof(MailManage));
        }
        public IActionResult DeActive(int id)
        {
            _mailService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _mailService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _mailService.SetNotDeleted(id);
            return RedirectToAction(nameof(MailManage));
        }
    }
}
