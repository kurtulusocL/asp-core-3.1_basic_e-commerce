using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class RandomProduct:ViewComponent
    {
        private readonly IProductService _productService;
        public RandomProduct(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_productService.GetAllProductInclude().OrderByDescending(i => Guid.NewGuid()).Take(5));
        }
    }
}
