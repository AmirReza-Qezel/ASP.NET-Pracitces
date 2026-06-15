using Microsoft.AspNetCore.Mvc;

[Route("/{controller}/FP/{action}")]
public class HomeController : Controller
{
    // URL: /Home/FP/Index
    public IActionResult Index()
    {
        return View();
    }

    // URL: /Home/FP/Message/{msg}
    [HttpGet("{msg}")]  // Adds /{msg} to the end
    public IActionResult Message(string msg)
    {
        return StatusCode(200);
    }

    // URL: /Home/FP/Privacy
    public IActionResult Privacy()
    {
        return View();
    }
}