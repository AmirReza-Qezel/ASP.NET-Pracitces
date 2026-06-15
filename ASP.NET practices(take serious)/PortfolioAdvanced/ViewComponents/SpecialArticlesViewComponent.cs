using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PortfolioAdvanced.Data;
using PortfolioAdvanced.Models;

namespace PortfolioAdvanced.ViewComponentsC
{
    public class SpecialArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var specialArticles = ProjectStore.GetProject();
            return View("_SpecialArticles",specialArticles);
        }
    }
}
