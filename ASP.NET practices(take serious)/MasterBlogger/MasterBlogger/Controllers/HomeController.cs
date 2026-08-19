using Application.ArticleAgg;
using Application.Contract.ArticleAgg.Commands___DTOs;
using MasterBlogger.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MasterBlogger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArticleService _articleService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllAsync();
            ViewBag.NoArticleFound = (articles == null || articles.Count() == 0);
            return View(articles ?? new List<ArticleDTO>());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
