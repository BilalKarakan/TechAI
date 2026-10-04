using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.SubFeatureVC;

public class _SubFeature : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
