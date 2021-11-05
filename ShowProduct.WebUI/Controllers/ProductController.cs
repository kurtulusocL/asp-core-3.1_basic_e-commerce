using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShowProduct.Business.Abstract;
using ShowProduct.Core.CrossCuttingConcert.DTOs.Entities.UpdateModels;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly ICommentService _commentService;
        private readonly IReportService _reportService;
        private readonly IPictureService _pictureService;
        private readonly ICategoryService _categoryService;
        private readonly ISubcategoryService _subcategoryService;
        private readonly ITagService _tagService;
        private readonly IBoxService _boxService;
        public ProductController(IProductService productService, IProductDetailService productDetailService, ICommentService commentService, IReportService reportService, IPictureService pictureService, ICategoryService categoryService, ISubcategoryService subcategoryService, ITagService tagService, IBoxService boxService)
        {
            _productService = productService;
            _productDetailService = productDetailService;
            _commentService = commentService;
            _reportService = reportService;
            _pictureService = pictureService;
            _categoryService = categoryService;
            _subcategoryService = subcategoryService;
            _tagService = tagService;
            _boxService = boxService;
        }
        public IActionResult Index(int page = 1)
        {
            return View(_productService.GetAllProductInclude().ToPagedList(page, 24));
        }
        public IActionResult Category(int? id, int page = 1)
        {
            return View(_productService.GetAllCategoryById(id).ToPagedList(page, 24));
        }
        public IActionResult Subcategory(int? id, int page = 1)
        {
            return View(_productService.GetAllSubcategoryById(id).ToPagedList(page, 24));
        }
        public IActionResult Tag(int? id, int page = 1)
        {
            return View(_tagService.GetAllProductById(id).ToPagedList(page, 24));
        }
        public IActionResult SpecialOffer(int page = 1)
        {
            return View(_productService.GetAllSpecialOffer().ToPagedList(page, 24));
        }
        public IActionResult Detail(int? id)
        {
            return View(_productService.GetProductById(id));
        }
        public IActionResult HitRead(int? id)
        {
            return View(_productService.HitRead(id));
        }
        public IActionResult AddBox(int id)
        {
            var product = _productService.GetById(id);
            _boxService.AddBox(product);
            TempData["msg"] = "The product is in your box.";
            return RedirectToAction(nameof(Detail), new { id = product.Id });
        }
        public IActionResult CustomerBox()
        {
            return View(_boxService.BoxProductList());
        }
        public IActionResult GetEmptyBox()
        {
            _boxService.EmptyBox();
            return RedirectToAction(nameof(CustomerBox));
        }
        public IActionResult DeleteFromBox(int id)
        {
            var product = _productService.GetById(id);
            _boxService.DeleteBox(product);
            return RedirectToAction(nameof(CustomerBox));
        }
        public IActionResult CreateComment(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            Comment model = new Comment
            {
                ProductId = id
            };
            return View("CreateComment", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateComment(int? productId, string namesuname, string emailaddress, string subject, string text)
        {
            var model = new Comment
            {
                ProductId = productId,
                NameSuname = namesuname,
                EMailAddress = emailaddress,
                Subject = subject,
                Text = text,
            };
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _commentService.Create(model);
                return RedirectToAction(nameof(Detail), new { id = model.ProductId });
            }
        }
        public IActionResult CreateReport(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            Report model = new Report
            {
                ProductId = id
            };
            return View("CreateReport", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReport(int? productId, string namesuname, string emailaddress, string phonenumber, string subject, string text)
        {
            var model = new Report
            {
                ProductId = productId,
                NameSuname = namesuname,
                EmailAddress = emailaddress,
                PhoneNumber = phonenumber,
                Subject = subject,
                Text = text,
            };
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _reportService.Create(model);
                return RedirectToAction(nameof(Detail), new { id = model.ProductId });
            }
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_productService.GetAllProductInclude().ToPagedList(page, 15));
        }
        public IActionResult ProductDetailList(int page = 1)
        {
            return View(_productDetailService.GetAllProductDetailInclude().ToPagedList(page, 15));
        }
        public IActionResult CategoryList(int? id, int page = 1)
        {
            return View(_productService.GetAllCategoryByIdWithoutParameter(id).ToPagedList(page, 15));
        }
        public IActionResult SubcategoryList(int? id, int page = 1)
        {
            return View(_productService.GetAllSubcategoryByIdWithoutParameter(id).ToPagedList(page, 15));
        }
        public IActionResult Commentable(int page = 1)
        {
            return View(_productService.GetAllCommentable().ToPagedList(page, 15));
        }
        public IActionResult NotCommentable(int page = 1)
        {
            return View(_productService.GetAllNotCommentable().ToPagedList(page, 15));
        }
        public IActionResult SpecialOfferList(int page = 1)
        {
            return View(_productService.GetAllSpecialOfferWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult NotSpecialOffer(int page = 1)
        {
            return View(_productService.GetAllNotSpecialOffer().ToPagedList(page, 15));
        }
        public IActionResult ProductDetail(int? id)
        {
            return View(_productService.GetById(id));
        }
        public IActionResult ProductDetailInfo(int? id)
        {
            return View(_productDetailService.GetAllProductById(id));
        }
        public IActionResult ProductManage(int page = 1)
        {
            return View(_productService.GetAllProductIncludeWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult ProductDetailManage(int page=1)
        {
            return View(_productDetailService.GetAllProductDetailIncludeWithoutParameter().ToPagedList(page, 15));
        }
        public IActionResult CreateProduct()
        {
            ViewBag.Categories = _categoryService.GetAllCategoryInclude();
            ViewBag.Subcategories = _subcategoryService.GetAllSubcategoryInclude();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProduct(Product model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _productService.Create(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult EditProduct(int? id)
        {
            ViewBag.Categories = _categoryService.GetAllCategoryIncludeWithoutParameter();
            ViewBag.Subcategories = _subcategoryService.GetAllSubcategoryIncludeWithoutParameter();
            var updateProduct = _productService.GetById(id);

            if (updateProduct != null)
            {
                return View(updateProduct);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(Product model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _productService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public ActionResult EditProductPrice(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            var updatePrice = _productService.GetById(id);
            var model = new ProductPriceUpdate()
            {
                Id = updatePrice.Id,
                Price = updatePrice.Price
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProductPrice(ProductPriceUpdate model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                var product = _productService.GetById(model.Id);
                product.Price = model.Price;
                _productService.Update(product);
                return RedirectToAction(nameof(kurtulusocL));
            }  
        }
        public IActionResult CreateTag(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            Tag model = new Tag
            {
                ProductId = id
            };
            return View("CreateTag", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateTag(int? productId, string name)
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
                return RedirectToAction("kurtulusocL", "Tag");
            }
        }
        public IActionResult CreateProductDetail(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            ProductDetail model = new ProductDetail
            {
                ProductId = id
            };
            return View("CreateProductDetail", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProductDetail(int? productId, string desc, string detail, string warning)
        {
            var model = new ProductDetail
            {
                ProductId = productId,
                Desc = desc,
                Detail = detail,
                Warning = warning
            };
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _productDetailService.Create(model);
                return RedirectToAction(nameof(ProductDetailList));
            }
        }
        public IActionResult EditProductDetail(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            ProductDetail model = new ProductDetail
            {
                ProductId = id
            };
            return View("EditProductDetail", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProductDetail(int? productId, string desc, string detail, string warning)
        {
            var model = new ProductDetail
            {
                ProductId = productId,
                Desc = desc,
                Detail = detail,
                Warning = warning
            };
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _productDetailService.Update(model);
                return RedirectToAction(nameof(ProductDetailList));
            }
        }
        public IActionResult CreatePicture(int? id)
        {
            ViewBag.ProductId = _productService.GetById(id);
            Picture model = new Picture
            {
                ProductId = id,
            };
            return View("CreatePicture", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePicture(int? productId, IEnumerable<IFormFile> images)
        {
            foreach (var image in images)
            {
                var model = new Picture
                {
                    ProductId = productId,
                };
                var path = Path.GetExtension(image.FileName);
                var photoName = Guid.NewGuid() + path;
                var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/dinamic/product/" + photoName);
                var stream = new FileStream(upload, FileMode.Create);
                image.CopyTo(stream);
                model.ImageUrl = photoName;

                _pictureService.Create(model);
            }
            return RedirectToAction("kurtulusocL", "Picture");
        }
        public IActionResult SetCommentable(int id)
        {
            _productService.SetCommentable(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult SetNotCommentable(int id)
        {
            _productService.SetNotCommentable(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult SetSpecialOffer(int id)
        {
            _productService.SetSpecialOffer(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult SetNotSpecialOffer(int id)
        {
            _productService.SetNotSpecialOffer(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Active(int id)
        {
            _productService.SetActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult DeActive(int id)
        {
            _productService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult ActiveDetail(int id)
        {
            _productDetailService.SetActive(id);
            return RedirectToAction(nameof(ProductDetailList));
        }
        public IActionResult DeActiveDetail(int id)
        {
            _productDetailService.SetDeActive(id);
            return RedirectToAction(nameof(ProductDetailList));
        }
        public IActionResult Deleted(int id)
        {
            _productService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _productService.SetNotDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult DeleteDetail(int id)
        {
            _productDetailService.SetDeleted(id);
            return RedirectToAction(nameof(ProductDetailList));
        }
        public IActionResult NotDeletedDetail(int id)
        {
            _productDetailService.SetNotDeleted(id);
            return RedirectToAction(nameof(ProductDetailList));
        }
        public IActionResult DeleteProduct(int? id)
        {
            var deleteProduct = _productService.GetById(id);
            if (deleteProduct != null)
            {
                _productService.Delete(deleteProduct);
                return RedirectToAction(nameof(ProductManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult DeleteProductDetail(int? id)
        {
            var deleteProductDetail = _productDetailService.GetById(id);
            if (deleteProductDetail != null)
            {
                _productDetailService.Delete(deleteProductDetail);
                return RedirectToAction(nameof(ProductDetailManage));
            }
            else
            {
                return NotFound();
            }
        }

    }
}