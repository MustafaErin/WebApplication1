using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dal.Context;

namespace WebApplication1.Controllers
{
    public class MessageController : Controller
    {
        PortfolyoContext context = new PortfolyoContext();
        public IActionResult inbox()
        {
            var values=context.Messages.ToList();
            return View(values);
        }
        public IActionResult ChangeStatus(int id)
        {
            var values = context.Messages.Find(id);

            if (values.IsRead == true) 
            {
                values.IsRead = false;
            }
            else
            {
                values.IsRead = true;
            }
           context.SaveChanges();
            return RedirectToAction("inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("inbox");
        }
        public IActionResult MessageDetail(int id)
        {
            var values = context.Messages.Find(id);
            return View(values);
        }
    }
}
