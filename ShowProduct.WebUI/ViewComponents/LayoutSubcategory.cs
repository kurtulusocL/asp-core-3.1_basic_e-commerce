using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class LayoutSubcategory : ViewComponent
    {
        private readonly ISubcategoryService _subcategoryService;
        public LayoutSubcategory(ISubcategoryService subcategoryService)
        {
            _subcategoryService = subcategoryService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_subcategoryService.GetAllSubcategoryInclude());
        }
    }
}
