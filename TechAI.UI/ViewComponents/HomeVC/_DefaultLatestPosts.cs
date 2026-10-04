using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.HomeVC;

public class _DefaultLatestPosts : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
