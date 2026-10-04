using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.LayoutVC;

public class _LayoutRightSideBar : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
