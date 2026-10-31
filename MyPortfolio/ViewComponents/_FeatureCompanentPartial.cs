using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contex;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureCompanentPartial:ViewComponent
    {
        MyPortofolioContext porfolioContext = new MyPortofolioContext();
        public IViewComponentResult Invoke()
        {
            var values = porfolioContext.Features.ToList();
            return View(values);
        }
    }
}
