using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        Contact contact = new Contact("ghezel2000@gmail.com","+989936801283","Github/AmiRezaQezel");
        public IActionResult Index()
        {
            return View(contact);
        }
    }
}
