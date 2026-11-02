using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

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
