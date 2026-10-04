using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.LayoutVC;

public class _LayoutScripts : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
