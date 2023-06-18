using Microsoft.AspNetCore.Mvc;

namespace Two.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();     //The view template /Views/HelloWorld/Index.cshtml is used.
        }
        public IActionResult Wellcome(String name, int NumTimes = 1)
        {
            List<Int32> times = new List<Int32>();
            ViewData["times"] = times;    
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = NumTimes;
            return View();
        }
    }
}
