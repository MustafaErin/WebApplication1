using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewCompanents
{
    public class _HeadCompanentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
