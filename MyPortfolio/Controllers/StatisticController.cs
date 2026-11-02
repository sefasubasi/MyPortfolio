using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        
        MyPortofolioContext db = new MyPortofolioContext();
        public IActionResult Index()
        {
            ViewBag.SkillsCount = db.Skills.Count();
            ViewBag.MessagesCount = db.Messages.Count();
            ViewBag.ReadMessagesCount = db.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.NoReadMessagesCount = db.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
