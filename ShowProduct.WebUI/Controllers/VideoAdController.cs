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
    public class VideoAdController : Controller
    {
        private readonly IVideoAdService _videoAdService;
        public VideoAdController(IVideoAdService videoAdService)
        {
            _videoAdService = videoAdService;
        }
        public IActionResult HitRead(int? id)
        {
            return View(_videoAdService.HitRead(id));
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_videoAdService.GetAll().ToPagedList(page, 15));
        }
        public IActionResult VideoAdManage(int page = 1)
        {
            return View(_videoAdService.GetAllWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult Detail(int? id)
        {
            return View(_videoAdService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VideoAd model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _videoAdService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            var updateVideoAd = _videoAdService.GetById(id);
            if (updateVideoAd != null)
            {
                return View(updateVideoAd);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VideoAd model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _videoAdService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteVideoAd = _videoAdService.GetById(id);
            if (deleteVideoAd != null)
            {
                _videoAdService.Delete(deleteVideoAd);
                return RedirectToAction(nameof(VideoAdManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _videoAdService.SetActive(id);
            return RedirectToAction(nameof(VideoAdManage));
        }
        public IActionResult DeActive(int id)
        {
            _videoAdService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _videoAdService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _videoAdService.SetNotDeleted(id);
            return RedirectToAction(nameof(VideoAdManage));
        }
    }
}
