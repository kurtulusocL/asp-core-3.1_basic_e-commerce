using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class ProductDetailInformation:ViewComponent
    {
        private readonly IProductDetailService _productDetailService;
        public ProductDetailInformation(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }
        public IViewComponentResult Invoke(int? id)
        {
            return View(_productDetailService.GetProductById(id));
        }
    }
}
