using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class FooterSocialMedia:ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;
        public FooterSocialMedia(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_socialMediaService.GetAll());
        }
    }
}
