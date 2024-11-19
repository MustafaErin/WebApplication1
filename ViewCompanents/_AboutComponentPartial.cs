using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;

namespace WebApplication1.ViewCompanents
{
    public class _AboutComponentPartial:ViewComponent
    {
        PortfolyoContext context=new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.AboutTitle = context.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.Details = context.Abouts.Select(x=>x.Details).FirstOrDefault();
            ViewBag.SubDescription = context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            return View();
        }
    }
}
