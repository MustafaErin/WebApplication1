using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;
using WebApplication1.Models.Dal.entities;

namespace WebApplication1.ViewCompanents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
