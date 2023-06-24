using Microsoft.AspNetCore.Mvc;

namespace Q3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }    
}
