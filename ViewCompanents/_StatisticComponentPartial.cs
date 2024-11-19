using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewCompanents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
