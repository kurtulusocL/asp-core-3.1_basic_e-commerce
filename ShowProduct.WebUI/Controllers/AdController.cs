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
    public class AdController : Controller
    {
        private readonly IAdService _adService;
        public AdController(IAdService adService)
        {
            _adService = adService;
        }
        public IActionResult HitRead(int? id)
        {
            return View(_adService.HitRead(id));
        }
        public IActionResult kurtulusocL(int page=1)
        {
            return View(_adService.GetAll().ToPagedList(page, 20));
        }
        public IActionResult AdManage(int page=1)
        {
            return View(_adService.GetAllWithoutParameter().ToPagedList(page, 25));
        }
        public IActionResult Detail(int? id)
        {
            return View(_adService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ad model, IFormFile image)
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
                    var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/dinamic/ad/" + photoName);
                    var stream = new FileStream(upload, FileMode.Create);
                    image.CopyTo(stream);
                    model.Photo = photoName;
                }
                _adService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            var updateAd = _adService.GetById(id);
            if (updateAd != null)
            {
                return View(updateAd);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Ad model, IFormFile image)
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
                    var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/dinamic/ad/" + photoName);
                    var stream = new FileStream(upload, FileMode.Create);
                    image.CopyTo(stream);
                    model.Photo = photoName;
                }
                _adService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteAd = _adService.GetById(id);
            if (deleteAd != null)
            {
                _adService.Delete(deleteAd);
                return RedirectToAction(nameof(AdManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _adService.SetActive(id);
            return RedirectToAction(nameof(AdManage));
        }
        public IActionResult DeActive(int id)
        {
            _adService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _adService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _adService.SetNotDeleted(id);
            return RedirectToAction(nameof(AdManage));
        }
    }
}