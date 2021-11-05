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
    public class PictureController : Controller
    {
        private readonly IPictureService _pictureService;
        private readonly IProductService _productService;
        public PictureController(IPictureService pictureService, IProductService productService)
        {
            _pictureService = pictureService;
            _productService = productService;
        }
        public IActionResult kurtulusocL(int page=1)
        {
            return View(_pictureService.GetAllPictureInclude().ToPagedList(page, 50));
        }
        public IActionResult Product(int? id, int page=1)
        {
            return View(_pictureService.GetAllProductById(id).ToPagedList(page, 10));
        }
        public IActionResult PictureManage(int page=1)
        {
            return View(_pictureService.GetAllPictureIncludeWithoutParameter().ToPagedList(page, 75));
        }
        public IActionResult Detail(int? id)
        {
            return View(_pictureService.GetById(id));
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.ProductId = _pictureService.GetAllProductById(id);
            Picture model = new Picture
            {
                ProductId = id,
            };
            return PartialView("Edit", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? productId, IEnumerable<IFormFile> images)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                var model = new Picture
                {
                    ProductId = productId,
                };
                foreach (var image in images)
                {
                    var path = Path.GetExtension(image.FileName);
                    var photoName = Guid.NewGuid() + path;
                    var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/product/" + photoName);
                    var stream = new FileStream(upload, FileMode.Create);
                    image.CopyTo(stream);
                    model.ImageUrl = photoName;
                }
                _pictureService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deletePicture = _pictureService.GetById(id);
            if (deletePicture != null)
            {
                _pictureService.Delete(deletePicture);
                return RedirectToAction(nameof(PictureManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _pictureService.SetActive(id);
            return RedirectToAction(nameof(PictureManage));
        }
        public IActionResult DeActive(int id)
        {
            _pictureService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _pictureService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _pictureService.SetNotDeleted(id);
            return RedirectToAction(nameof(PictureManage));
        }
    }
}
