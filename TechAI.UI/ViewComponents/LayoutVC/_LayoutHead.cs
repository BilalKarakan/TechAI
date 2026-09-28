using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.LayoutVC;

public class _LayoutHead : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
