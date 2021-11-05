using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class ContactSocialMedia:ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;
        public ContactSocialMedia(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_socialMediaService.GetAll());
        }
    }
}
