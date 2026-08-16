using Application.ArticleAgg;
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

        public IActionResult Index()
        {
            var articles = _articleService.GetAllAsync();
            return View(articles);
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
