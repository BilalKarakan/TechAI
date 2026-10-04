using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.HomeVC;

public class _DefaultPostsWithVideos : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
