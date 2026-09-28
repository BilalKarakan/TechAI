using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
