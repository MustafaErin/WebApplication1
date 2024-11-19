using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewCompanents.LayoutViewComponent
{
    public class _LayoutNavbarComponentPartial: ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
