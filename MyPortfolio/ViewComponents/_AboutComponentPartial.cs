using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortofolioContext db = new MyPortofolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = db.Abouts.Select(a => a.Title).FirstOrDefault();  
            ViewBag.aboutSubDescription = db.Abouts.Select(a => a.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = db.Abouts.Select(a => a.Details).FirstOrDefault();
            return View();
        }
    }
}
