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
            var Guy = new Guy
            {
                Name = "Home",
                Description = "Home",
                Passport = new Passport {Code = "125366" }
            };
            //var book5 = _peopleContext.Books.Include(b => b.Categories).ToList();
            //var book6 = _peopleContext.Books.AsNoTracking().FirstOrDefault(b => b.Id == 5);
            //_peopleContext.Entry(book6).Collection(b => b.Categories).Load();
            //_peopleContext.Entry(book1).Property("CreatedAt").CurrentValue = DateTime.Now;
            //var categorySample = _peopleContext.Categories.First();
            //book1.Categories.Add(categorySample);
            //_peopleContext.Books.Add(book1);
            _peopleContext.Guys.Add(Guy);
            _peopleContext.SaveChanges();
            var guy1 = _peopleContext.Guys.FirstOrDefault(g => g.Id == 3);
            var pass = guy1.Passport.Code;
            //var state = _peopleContext.ChangeTracker.Entries();
            //var guy3 = _peopleContext.Guys.AsNoTracking().SingleOrDefault(x => x.Id == 2);
            //guy3.IsRemoved = true;
            //_peopleContext.SaveChanges();
            //var allBooksWithCategories = _peopleContext.Books
            //    .Include(b => b.Categories)
            //    .ToList(); 
            ViewData["AnyResult"] = $"{pass}";

            //var books = _peopleContext.Books.FromSqlRaw("SELECT * FROM Books").ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
