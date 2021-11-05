using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShowProduct.Business.Abstract;
using ShowProduct.Business.Extensions.UserLogging;
using ShowProduct.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    [UserLog]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;      
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SearchResult(string key, int page = 1)
        {
            return View(_productService.GetAllProductSearch(key).ToPagedList(page, 24));
        }
        public IActionResult NotFound(int code)
        {
            ViewBag.Code = 404;
            return View();
        }
    }
}