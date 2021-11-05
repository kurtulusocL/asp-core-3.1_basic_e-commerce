using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class VideoAdHit:ViewComponent
    {
        private readonly IVideoAdService _videoAdService;
        public VideoAdHit(IVideoAdService videoAdService)
        {
            _videoAdService = videoAdService;
        }
        public IViewComponentResult Invoke(int? id)
        {
            return View(_videoAdService.HitRead(id));
        }
    }
}
