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
    public class SubcategoryController : Controller
    {
        private readonly ISubcategoryService _subcategoryService;
        private readonly ICategoryService _categoryService;
        public SubcategoryController(ISubcategoryService subcategoryService, ICategoryService categoryService)
        {
            _subcategoryService = subcategoryService;
            _categoryService = categoryService;
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_subcategoryService.GetAllSubcategoryInclude().ToPagedList(page, 15));
        }
        public IActionResult SubcategoryManage(int page = 1)
        {
            return View(_subcategoryService.GetAllSubcategoryIncludeWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult Category(int? id, int page = 1)
        {
            return View(_subcategoryService.GetAllCategoryByIdWithoutParameter(id).ToPagedList(page, 15));
        }
        public IActionResult Detail(int id)
        {
            return View(_subcategoryService.GetById(id));
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _categoryService.GetAllCategoryInclude();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subcategory model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _subcategoryService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.Categories = _categoryService.GetAllCategoryInclude();
            var updateSubcategory = _subcategoryService.GetById(id);
            if (updateSubcategory != null)
            {
                return View(updateSubcategory);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Subcategory model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _subcategoryService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteSubcategory = _subcategoryService.GetById(id);
            if (deleteSubcategory != null)
            {
                _subcategoryService.Delete(deleteSubcategory);
                return RedirectToAction(nameof(SubcategoryManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _subcategoryService.SetActive(id);
            return RedirectToAction(nameof(SubcategoryManage));
        }
        public IActionResult DeActive(int id)
        {
            _subcategoryService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _subcategoryService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _subcategoryService.SetNotDeleted(id);
            return RedirectToAction(nameof(SubcategoryManage));
        }
    }
}
