using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message =$"Hello World. {DateAndTime.Now.ToString()}";
            return View("Index1",message);
        }
        public ViewResult Index2()
        {
            return View("Index");
        }
        public IActionResult Index3()
        {
            return Content("Employee");
        }
    }
}