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
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;
        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IActionResult kurtulusocL()
        {
            return View(_socialMediaService.GetAll());
        }
        public IActionResult SocialMediaManage(int page = 1)
        {
            return View(_socialMediaService.GetAllWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult Detail(int? id)
        {
            return View(_socialMediaService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SocialMedia model, IFormFile image)
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
                    var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/dinamic/socialmedia/" + photoName);
                    var stream = new FileStream(upload, FileMode.Create);
                    image.CopyTo(stream);
                    model.Logo = photoName;
                }
                _socialMediaService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            var updateSocial = _socialMediaService.GetById(id);
            if (updateSocial != null)
            {
                return View(updateSocial);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SocialMedia model, IFormFile image)
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
                    var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/dinamic/socialmedia/" + photoName);
                    var stream = new FileStream(upload, FileMode.Create);
                    image.CopyTo(stream);
                    model.Logo = photoName;
                }
                _socialMediaService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteSocial = _socialMediaService.GetById(id);
            if (deleteSocial != null)
            {
                _socialMediaService.Delete(deleteSocial);
                return RedirectToAction(nameof(SocialMediaManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _socialMediaService.SetActive(id);
            return RedirectToAction(nameof(SocialMediaManage));
        }
        public IActionResult DeActive(int id)
        {
            _socialMediaService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _socialMediaService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _socialMediaService.SetNotDeleted(id);
            return RedirectToAction(nameof(SocialMediaManage));
        }
    }
}
