using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contex;

namespace MyPortfolio.ViewComponents
{
    public class _ExprienceComponentPartial:ViewComponent
    {
        MyPortofolioContext db = new MyPortofolioContext();
        public IViewComponentResult Invoke()
        {
            var values = db.Experiences.ToList();
            return View(values);
        }
    }
}
