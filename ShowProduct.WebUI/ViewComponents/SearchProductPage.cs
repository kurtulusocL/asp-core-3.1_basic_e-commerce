using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class SearchProductPage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
