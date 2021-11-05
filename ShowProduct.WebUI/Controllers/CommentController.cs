using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult HitRead(int? id)
        {
            return View(_commentService.HitRead(id));
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_commentService.GetAllCommentInclude().ToPagedList(page, 35));
        }
        public IActionResult Product(int? id, int page = 1)
        {
            return View(_commentService.GetAllProductById(id).ToPagedList(page, 25));
        }
        public IActionResult CommentManage(int page = 1)
        {
            return View(_commentService.GetAllCommentIncludeWithoutParameter().ToPagedList(page, 45));
        }
        public IActionResult Detail(int? id)
        {
            return View(_commentService.GetById(id));
        }
        public IActionResult Delete(int? id)
        {
            var deleteComment = _commentService.GetById(id);
            if (deleteComment != null)
            {
                _commentService.Delete(deleteComment);
                return RedirectToAction(nameof(CommentManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(int id)
        {
            _commentService.SetActive(id);
            return RedirectToAction(nameof(CommentManage));
        }
        public IActionResult DeActive(int id)
        {
            _commentService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _commentService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _commentService.SetNotDeleted(id);
            return RedirectToAction(nameof(CommentManage));
        }
    }
}
