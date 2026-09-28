using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
