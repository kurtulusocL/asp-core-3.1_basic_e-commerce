using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        public AdminController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminList(int page = 1)
        {
            return View(_userService.GetAll().ToPagedList(page, 15));
        }
        public IActionResult UserList(int page = 1)
        {
            return View(_userService.GetAllUser().ToPagedList(page, 15));
        }
        public IActionResult Delete(string id)
        {
            var deleteUser = _userService.GetUserById(id);
            if (deleteUser != null)
            {
                _userService.Delete(deleteUser);
                return RedirectToAction(nameof(AdminList));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Active(string id)
        {
            _userService.SetActive(id);
            return RedirectToAction(nameof(AdminList));
        }
        public IActionResult DeActive(string id)
        {
            _userService.SetDeActive(id);
            return RedirectToAction(nameof(AdminList));
        }
        public IActionResult Deleted(string id)
        {
            _userService.Deleted(id);
            return RedirectToAction(nameof(AdminList));
        }
        public IActionResult NotDeleted(string id)
        {
            _userService.SetNotDeleted(id);
            return RedirectToAction(nameof(AdminList));
        }
    }
}
