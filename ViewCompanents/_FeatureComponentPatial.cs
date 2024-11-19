using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;

namespace WebApplication1.ViewCompanents
{
    public class _FeatureComponentPatial: ViewComponent
    {
        PortfolyoContext _Context=new PortfolyoContext();   
        public IViewComponentResult Invoke()
        {
            var values= _Context.Features.ToList();
            return View(values);
        }
    }
}
