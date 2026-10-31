using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contex;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortofolioContext context = new MyPortofolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
