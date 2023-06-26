using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{   

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RazorSyntax()
        {
            ViewData["FirstName"] = "Victoria";
            ViewData["emp"] = new Employee()
            {
                ID = 1234,
                Name = "Jonny"
            };
            ViewBag.Emp = new Employee()
            {
                ID = 12343,
                Name = "viewbagDemo"
            };
            List<string> nameList = new List<string>();
            nameList.Add("name1");
            nameList.Add("name2");
            nameList.Add("name3");
            nameList.Add("name4");
            nameList.Add("name5");
            TempData["names"] = nameList;
            

            return View();
        }
    }
}
