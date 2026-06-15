using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace PortfolioAdvanced.Controllers
{
    public class Test : Controller
    {
        public JavaScriptResult Index()
        {
            return new JavaScriptResult("alert('hi dude')");
        }
        public RedirectToActionResult callRedirect()
        {
            return RedirectToAction("Index", "Home");
        }
        public StatusCodeResult status()
        {
            //return new BadRequestResult();
            //return new OkResult();
            //return new NoContentResult();
            return new StatusCodeResult(501);
        }
    }
    public class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string data)
        {
            Content = data;
            ContentType = "text/javascript";
        }
    }
}
