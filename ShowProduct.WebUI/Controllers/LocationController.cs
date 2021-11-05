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
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_locationService.GetAll().ToPagedList(page, 10));
        }
        public IActionResult LocationManage(int page = 1)
        {
            return View(_locationService.GetAllWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult Detail(int? id)
        {
            return View(_locationService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Location model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _locationService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            var updateLocation = _locationService.GetById(id);
            if (updateLocation != null)
            {
                return View(updateLocation);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Location model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _locationService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteLocation = _locationService.GetById(id);
            if (deleteLocation != null)
            {
                _locationService.Delete(deleteLocation);
                return RedirectToAction(nameof(LocationManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _locationService.SetActive(id);
            return RedirectToAction(nameof(LocationManage));
        }
        public IActionResult DeActive(int id)
        {
            _locationService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _locationService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _locationService.SetNotDeleted(id);
            return RedirectToAction(nameof(LocationManage));
        }
    }
}
