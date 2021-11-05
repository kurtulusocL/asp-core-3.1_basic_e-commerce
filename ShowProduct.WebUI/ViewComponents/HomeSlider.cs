using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class HomeSlider : ViewComponent
    {
        private readonly IPictureService _pictureService;
        public HomeSlider(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_pictureService.GetAllPictureInclude().OrderByDescending(i => Guid.NewGuid()).Take(5));
        }
    }
}
