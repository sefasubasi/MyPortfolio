using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortofolioContext db = new MyPortofolioContext();
        public IActionResult Index()
        {
            var values = db.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            db.ToDoLists.Add(toDoList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteToDoList(int id)
        {
            var value = db.ToDoLists.Find(id);
            db.ToDoLists.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = db.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            db.ToDoLists.Update(toDoList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = db.ToDoLists.Find(id);
            value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = db.ToDoLists.Find(id);
            value.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
