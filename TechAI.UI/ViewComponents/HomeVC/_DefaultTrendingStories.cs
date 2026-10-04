using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.HomeVC;

public class _DefaultTrendingStories : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
