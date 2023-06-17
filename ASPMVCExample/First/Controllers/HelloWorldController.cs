using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace First.Controllers
{
    public class HelloWorldController : Controller
    {
        //    /[Controller]/[ActionName]/[Parameters]
        public String Index()
        {
            return "This is my default action..."; //   /HelloWorld/
        }
        public String WellCome()
        {
            return "This is the Welcome action method...";  //   /HelloWorld/Welcome/
        }
        public String Hello(String name, int NumberTimes)
        {
            return $"Hello {name}, NumTimes is: {NumberTimes}";  //  /HelloWorld/Hello?name=Hoan&NumberTimes=4  
        }
        public String Hello2(String name, int iD = 1)
        {
            return $"Hello {name}, NumTimes is: {iD}";  //  /HelloWorld/Hello2/3?name=Hoan    ; Test with /HelloWorld/Hello2?name=Hoan
        }
  
        //app.MapControllerRoute(
        //name: "default",
        //pattern: "{controller=Home}/{action=Index}/{id?}");
    }
}
