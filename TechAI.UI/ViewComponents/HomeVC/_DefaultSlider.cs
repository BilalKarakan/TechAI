using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.HomeVC;

public class _DefaultSlider : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
