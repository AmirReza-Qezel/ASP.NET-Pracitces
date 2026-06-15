using System.Diagnostics;
using EntityFrameworkPracticing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPracticing.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeopleContext _peopleContext;
        

        public HomeController(PeopleContext peopleContext)
        {
            _peopleContext = peopleContext;
        }

        public IActionResult Index()
        {
            var guy = new Guy("Ali","the first member of my database ;D");
            var guy2 = new Guy("Mohammad", "the second member of my database ;D");
            _peopleContext.Guys.Add(guy);
            _peopleContext.Guys.Add(guy2);
            var state = _peopleContext.ChangeTracker.Entries();
            var guy3 = _peopleContext.Guys.AsNoTracking().SingleOrDefault(x => x.Id == 5);
            guy3.IsRemoved = true;
            _peopleContext.SaveChanges();
            var allPeople = _peopleContext.Guys.ToList();
            ViewData["AnyResult"] = $"{_peopleContext.Guys.Find(5).Name}";
            return View(allPeople);
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
