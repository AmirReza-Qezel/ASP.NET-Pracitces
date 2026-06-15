using System.Diagnostics;
using DIPracticing.BLL;
using DIPracticing.Models;
using DIPracticing.Option;
using Microsoft.AspNetCore.Mvc;

namespace DIPracticing.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptionTransient _optionTransient;
        private readonly IOptionScoped _optionScoped;
        private readonly IOptionSingleton _optionSingleton;
        private readonly IGameService _game;

       

        public HomeController(IOptionTransient optionTransient, IOptionScoped optionScoped, IOptionSingleton optionSingleton)
        {
            _optionTransient = optionTransient;
            _optionScoped = optionScoped;
            _optionSingleton = optionSingleton;
            Console.WriteLine("These are each DIed Class wich had Services to register for DI Container to know what to do with them");
            Console.WriteLine($"{_optionTransient.Id}");
            Console.WriteLine($"{_optionScoped.Id}");
            Console.WriteLine($"{_optionSingleton.Id}");
        }

        public IActionResult Index()
        {
            return View();
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
