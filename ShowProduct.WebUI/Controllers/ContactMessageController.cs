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
    public class ContactMessageController : Controller
    {
        private readonly IContactMessageService _contactMessageService;
        public ContactMessageController(IContactMessageService contactMessageService)
        {
            _contactMessageService = contactMessageService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactMessage model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _contactMessageService.Create(model);
                TempData["message"] = "You sent message successfully. We Will type-back to you. Thank you...";
                return RedirectToAction(nameof(Index));
            }
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_contactMessageService.GetAll().ToPagedList(page, 45));
        }
        public IActionResult MessageManage(int page = 1)
        {
            return View(_contactMessageService.GetAllWithoutParameter().ToPagedList(page, 55));
        }
        public IActionResult Detail(int? id)
        {
            return View(_contactMessageService.GetById(id));
        }
        public IActionResult Delete(int? id)
        {
            var deleteMessage = _contactMessageService.GetById(id);
            if (deleteMessage != null)
            {
                _contactMessageService.Delete(deleteMessage);
                return RedirectToAction(nameof(MessageManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _contactMessageService.SetActive(id);
            return RedirectToAction(nameof(MessageManage));
        }
        public IActionResult DeActive(int id)
        {
            _contactMessageService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _contactMessageService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _contactMessageService.SetNotDeleted(id);
            return RedirectToAction(nameof(MessageManage));
        }
    }
}
