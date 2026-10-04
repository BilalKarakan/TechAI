using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.HomeVC;

public class _DefaultFeature : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
