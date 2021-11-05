using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class ProductDetailTag:ViewComponent
    {
        private readonly ITagService _tagService;
        public ProductDetailTag(ITagService tagService)
        {
            _tagService = tagService;
        }
        public IViewComponentResult Invoke(int? id)
        {
            return View(_tagService.GetAllProductById(id));
        }
    }
}
