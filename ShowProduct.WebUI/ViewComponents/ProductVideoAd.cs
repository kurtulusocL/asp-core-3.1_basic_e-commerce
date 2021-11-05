using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class ProductVideoAd:ViewComponent
    {
        private readonly IVideoAdService _videoAdService;
        public ProductVideoAd(IVideoAdService videoAdService)
        {
            _videoAdService = videoAdService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_videoAdService.GetAll().OrderByDescending(i => Guid.NewGuid()).Take(1));
        }
    }
}
