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
    public class TagController : Controller
    {
        private readonly ITagService _tagService;
        private readonly IProductService _productService;
        public TagController(ITagService tagService, IProductService productService)
        {
            _tagService = tagService;
            _productService = productService;
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_tagService.GetAllTagInclude().ToPagedList(page, 15));
        }
        public IActionResult Product(int? id, int page = 1)
        {
            return View(_tagService.GetAllProductByIdWithoutParameter(id).ToPagedList(page, 15));
        }
        public IActionResult Detail(int? id)
        {
            return View(_tagService.GetById(id));
        }
        public IActionResult TagManage(int page = 1)
        {
            return View(_tagService.GetAllTagIncludeWithoutParameter().ToPagedList(page, 25));
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            Tag model = new Tag
            {
                ProductId = id
            };
            return View("Edit", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? productId, string name)
        {
            var model = new Tag
            {
                ProductId = productId,
                Name = name
            };
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _tagService.Create(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteTag = _tagService.GetById(id);
            if (deleteTag != null)
            {
                _tagService.Delete(deleteTag);
                return RedirectToAction(nameof(TagManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _tagService.SetActive(id);
            return RedirectToAction(nameof(TagManage));
        }
        public IActionResult DeActive(int id)
        {
            _tagService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _tagService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _tagService.SetNotDeleted(id);
            return RedirectToAction(nameof(TagManage));
        }
    }
}
