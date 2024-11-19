using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;

namespace WebApplication1.ViewCompanents
{
    public class _ExperianceComponentPartial:ViewComponent
    {
        PortfolyoContext context=new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var value=context.Experiances.ToList();
            return View(value);
        }
    }
}
