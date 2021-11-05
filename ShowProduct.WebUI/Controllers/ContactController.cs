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
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View(_contactService.GetAll());
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_contactService.GetAll().ToPagedList(page, 10));
        }
        public IActionResult ContactDetail(int? id)
        {
            return View(_contactService.GetById(id));
        }
        public IActionResult ContactManage(int page = 1)
        {
            return View(_contactService.GetAllWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _contactService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int id)
        {
            var updateContact = _contactService.GetById(id);
            if (updateContact != null)
            {
                return View(updateContact);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Contact model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _contactService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteContact = _contactService.GetById(id);
            if (deleteContact != null)
            {
                _contactService.Delete(deleteContact);
                return RedirectToAction(nameof(ContactManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _contactService.SetActive(id);
            return RedirectToAction(nameof(ContactManage));
        }
        public IActionResult DeActive(int id)
        {
            _contactService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _contactService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _contactService.SetNotDeleted(id);
            return RedirectToAction(nameof(ContactManage));
        }
    }
}
