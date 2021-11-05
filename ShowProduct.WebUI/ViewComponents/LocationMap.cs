using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class LocationMap:ViewComponent
    {
        private readonly ILocationService _locationService;
        public LocationMap(ILocationService locationService)
        {
            _locationService = locationService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_locationService.GetAll());
        }
    }
}
