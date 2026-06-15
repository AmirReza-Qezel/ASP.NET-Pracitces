using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Practice1.Controllers
{
    public class TargetController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
