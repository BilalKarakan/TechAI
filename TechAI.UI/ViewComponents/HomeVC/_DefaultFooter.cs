using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.HomeVC;

public class _DefaultFooter : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
