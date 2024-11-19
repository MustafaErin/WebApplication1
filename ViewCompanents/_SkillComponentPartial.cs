using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;

namespace WebApplication1.ViewCompanents
{
    public class _SkillComponentPartial:ViewComponent
    {
        PortfolyoContext contex=new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var Values= contex.Skills.ToList();
            return View(Values);
        }
    }
}
