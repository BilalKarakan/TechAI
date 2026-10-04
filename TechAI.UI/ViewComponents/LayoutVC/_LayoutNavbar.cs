using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.LayoutVC;

public class _LayoutNavbar : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
