using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class Box : ViewComponent
    {
        //private readonly IBoxService _boxService;
        //public Box(IBoxService boxService)
        //{
        //    _boxService = boxService;
        //}
        public IViewComponentResult Invoke()
        {
            return View(/*_boxService.BoxProductList()*/);
        }
    }
}
