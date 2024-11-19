using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewCompanents
{
    public class _ContactCompanentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
