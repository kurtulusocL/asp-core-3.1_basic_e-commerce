using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowProduct.WebUI.ViewComponents
{
    public class HomeComment : ViewComponent
    {
        private readonly ICommentService _commentService;
        public HomeComment(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_commentService.GetAllCommentInclude().OrderByDescending(i => Guid.NewGuid()).Take(30));
        }
    }
}
