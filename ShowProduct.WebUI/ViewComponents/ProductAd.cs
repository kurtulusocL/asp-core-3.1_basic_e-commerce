using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class ProductAd : ViewComponent
    {
        private readonly IAdService _adService;
        public ProductAd(IAdService adService)
        {
            _adService = adService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_adService.GetAll().OrderByDescending(i => Guid.NewGuid()).Take(10));
        }
    }
}
