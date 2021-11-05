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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_categoryService.GetAllCategoryInclude().ToPagedList(page, 10));
        }
        public IActionResult CategoryManage(int page = 1)
        {
            return View(_categoryService.GetAllCategoryIncludeWithoutParameter().ToPagedList(page, 20));
        }
        public IActionResult Detail(int id)
        {
            return View(_categoryService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _categoryService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            var updateCategory = _categoryService.GetById(id);
            if (updateCategory != null)
            {
                return View(updateCategory);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _categoryService.Update(model);
                return RedirectToAction(nameof(Edit));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteCategory = _categoryService.GetById(id);
            if (deleteCategory != null)
            {
                _categoryService.Delete(deleteCategory);
                return RedirectToAction(nameof(CategoryManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _categoryService.SetActive(id);
            return RedirectToAction(nameof(CategoryManage));
        }
        public IActionResult DeActive(int id)
        {
            _categoryService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _categoryService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _categoryService.SetNotDeleted(id);
            return RedirectToAction(nameof(CategoryManage));
        }
    }
}