using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
