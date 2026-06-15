using Microsoft.AspNetCore.Mvc;
using PortfolioAdvanced.Models;

namespace PortfolioAdvanced.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<LatestArticle> latestArticles = new List<LatestArticle> {
            new LatestArticle(1, "Top 3 JavaScript Frameworks", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...", "1.jpg"),
            new LatestArticle(2, "About Remote Working", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...", "2.jpg"),
            new LatestArticle(3, "A Guide to Becoming a Full-Stack Developer", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...", "3.jpg")
            };
            return View("_LatestArticles", latestArticles);
        }
    }
}
