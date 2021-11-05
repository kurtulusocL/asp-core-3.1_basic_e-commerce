using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            return View(_aboutService.GetAll());
        }
        public IActionResult kurtulusocL()
        {
            return View(_aboutService.GetAll());
        }
        public IActionResult AboutManage(int page = 1)
        {
            return View(_aboutService.GetAllWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult Detail(int? id)
        {
            return View(_aboutService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(About model, IFormFile image)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                if (image != null)
                {
                    var path = Path.GetExtension(image.FileName);
                    var photoName = Guid.NewGuid() + path;
                    var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/dinamic/about/" + photoName);
                    var stream = new FileStream(upload, FileMode.Create);
                    image.CopyTo(stream);
                    model.Photo = photoName;
                }
                _aboutService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            var updateAbout = _aboutService.GetById(id);
            if (updateAbout != null)
            {
                return View(updateAbout);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(About model, IFormFile image)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                if (image != null && image.Length > 0)
                {
                    var path = Path.GetExtension(image.FileName);
                    var photoName = Guid.NewGuid() + path;
                    var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/dinamic/about/" + photoName);
                    var stream = new FileStream(upload, FileMode.Create, FileAccess.ReadWrite);
                    image.CopyTo(stream);
                    model.Photo = photoName;
                }
                _aboutService.Update(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteAbout = _aboutService.GetById(id);
            if (deleteAbout != null)
            {
                _aboutService.Delete(deleteAbout);
                return RedirectToAction(nameof(AboutManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _aboutService.SetActive(id);
            return RedirectToAction(nameof(AboutManage));
        }
        public IActionResult DeActive(int id)
        {
            _aboutService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _aboutService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _aboutService.SetNotDeleted(id);
            return RedirectToAction(nameof(AboutManage));
        }
    }
}