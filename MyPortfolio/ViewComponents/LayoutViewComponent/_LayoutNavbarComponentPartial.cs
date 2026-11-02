using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponent
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortofolioContext db = new MyPortofolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.ToDoListCount = db.ToDoLists.Where(x => x.Status == false).Count();
            var values = db.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
