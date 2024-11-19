using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;
using WebApplication1.Models.Dal.entities;

namespace WebApplication1.Controllers
{
    public class ExperianceController : Controller
    {
        PortfolyoContext context = new PortfolyoContext();
        public IActionResult ExperianceList()
        {
            var value = context.Experiances.ToList();
            return View(value);
        }
        public IActionResult CreateExperiance()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperiance(Experiance experiance)
        {
            context.Experiances.Add(experiance);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }
        public IActionResult DeleteExperiance(int id)
        {
            var value = context.Experiances.Find(id);
            context.Experiances.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }
        public IActionResult UpdateExperiance(int id)
        {
            var value = context.Experiances.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperiance(Experiance experiance)
        {
            context.Experiances.Update(experiance);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }
    }
}
