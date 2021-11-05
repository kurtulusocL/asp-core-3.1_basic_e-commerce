using Microsoft.AspNetCore.Mvc;
using ShowProduct.Business.Abstract;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ShowProduct.WebUI.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoService _toDoService;
        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }
        public IActionResult Index(int page = 1)
        {
            return View(_toDoService.GetAll().ToPagedList(page, 30));
        }
        public IActionResult kurtulusocL(int page = 1)
        {
            return View(_toDoService.GetAllTask().ToPagedList(page, 45));
        }
        public IActionResult TaskManage(int page = 1)
        {
            return View(_toDoService.GetAllWithoutParameter().ToPagedList(page, 55));
        }
        public IActionResult Detail(int? id)
        {
            return View(_toDoService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ToDo model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _toDoService.Create(model);
                return RedirectToAction(nameof(Create));
            }
        }
        public IActionResult Edit(int? id)
        {
            var updateTask = _toDoService.GetById(id);
            if (updateTask != null)
            {
                return View(updateTask);
            }
            return RedirectToAction(nameof(kurtulusocL));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ToDo model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            else
            {
                _toDoService.Update(model);
                return RedirectToAction(nameof(kurtulusocL));
            }
        }
        public IActionResult Delete(int? id)
        {
            var deleteTask = _toDoService.GetById(id);
            if (deleteTask != null)
            {
                _toDoService.Delete(deleteTask);
                return RedirectToAction(nameof(TaskManage));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Finished(int id)
        {
            _toDoService.SetFinished(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotFinished(int id)
        {
            _toDoService.SetNotFinished(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Active(int id)
        {
            _toDoService.SetActive(id);
            return RedirectToAction(nameof(TaskManage));
        }
        public IActionResult DeActive(int id)
        {
            _toDoService.SetDeActive(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult Deleted(int id)
        {
            _toDoService.SetDeleted(id);
            return RedirectToAction(nameof(kurtulusocL));
        }
        public IActionResult NotDeleted(int id)
        {
            _toDoService.SetNotDeleted(id);
            return RedirectToAction(nameof(TaskManage));
        }
    }
}
