using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class ProductTag : ViewComponent
    {
        private readonly ITagService _tagService;
        public ProductTag(ITagService tagService)
        {
            _tagService = tagService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_tagService.GetAllTagInclude().OrderByDescending(i => Guid.NewGuid()).Take(20));
        }
    }
}
