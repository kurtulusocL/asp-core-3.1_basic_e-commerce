using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class HomeContact:ViewComponent
    {
        private readonly IContactService _contactService;
        public HomeContact(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_contactService.GetAll().Take(1));
        }
    }
}
