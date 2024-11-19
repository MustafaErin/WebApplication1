using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;
using WebApplication1.Models.Dal.entities;

namespace WebApplication1.Controllers
{
    public class ToDoListController : Controller
    {
        PortfolyoContext context = new PortfolyoContext();
        public IActionResult index()
        {
            var value = context.ToDoLists.ToList();
            return View(value);
        }
        public IActionResult CreateToDo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDo(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult DeleteToDo(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult ChangeStatus(int id)
        {
            var values = context.ToDoLists.Find(id);

            if (values.Status == true)
            {
                values.Status = false;
            }
            else
            {
                values.Status = true;
            }
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult UpdateToDo(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDo(ToDoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
