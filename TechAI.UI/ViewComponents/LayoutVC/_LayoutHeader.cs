using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.LayoutVC;

public class _LayoutHeader : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
