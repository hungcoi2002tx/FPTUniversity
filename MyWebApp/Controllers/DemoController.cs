using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
