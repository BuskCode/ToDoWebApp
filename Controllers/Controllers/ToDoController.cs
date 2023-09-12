using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoWebApp.Models;

namespace ToDoWebApp.Controllers
{
    public class ToDoController : Controller
    {
        static List<ToDoItem> toDoList = new List<ToDoItem>();

        public IActionResult Index()
        {
            return View(toDoList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ToDoItem newItem)
        {
            if (ModelState.IsValid)
            {
                toDoList.Add(newItem);
                return RedirectToAction("Index");
            }

            return View(newItem);
        }

        public IActionResult Delete(int id)
        {
            var itemToRemove = toDoList.Find(item => item.Id == id);
            if (itemToRemove != null)
            {
                toDoList.Remove(itemToRemove);
            }
            return RedirectToAction("Index");
        }
    }
}
