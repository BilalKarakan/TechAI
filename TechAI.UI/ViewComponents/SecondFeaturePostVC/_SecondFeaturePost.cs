using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.SecondFeaturePostVC;

public class _SecondFeaturePost : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
