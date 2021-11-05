using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class AdHit : ViewComponent
    {
        private readonly IAdService _adService;
        public AdHit(IAdService adService)
        {
            _adService = adService;
        }
        public IViewComponentResult Invoke(int? id)
        {
            return View(_adService.HitRead(id));
        }
    }
}
