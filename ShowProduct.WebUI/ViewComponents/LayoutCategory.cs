using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class LayoutCategory : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public LayoutCategory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_categoryService.GetAllCategoryInclude());
        }
    }
}