using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponent
{
    public class _LayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
