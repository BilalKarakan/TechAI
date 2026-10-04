using Microsoft.AspNetCore.Mvc;

namespace TechAI.UI.ViewComponents.HomeVC;

public class _DefaultCategoriesWithLastArticles : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
