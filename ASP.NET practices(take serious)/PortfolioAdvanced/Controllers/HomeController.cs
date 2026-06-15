using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PortfolioAdvanced.Data;
using PortfolioAdvanced.Models;

namespace PortfolioAdvanced.Controllers
{
    public class HomeController : Controller
    {
        List<Service> services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس"),
        };
        public IActionResult ProjectDetail(int id)
        {
            var project = ProjectStore.GetProjectBy(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            Contact contact = new Contact
            {
                Services = new SelectList(services, "Id", "Name")
            };
            return View(contact);
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "please input valid information";
                return View(contact);
            }
            ModelState.Clear();
            contact = new Contact
            {
                Services = new SelectList(services, "Id", "Name")
            };
            ViewBag.Success = "operation was successful";
            return View(contact);
        }
    }
}
