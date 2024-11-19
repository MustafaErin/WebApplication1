using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewCompanents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
