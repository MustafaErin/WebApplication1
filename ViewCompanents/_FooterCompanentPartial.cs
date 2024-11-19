using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewCompanents
{
    public class _FooterCompanentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
