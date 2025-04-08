using Basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello World. {DateAndTime.Now.ToString()}";
            return View("Index1", message);
        }
        public ViewResult Index2()
        {
            var names = new String[]{
                "Aziz","Halil","Nuri"
            };
            return View(names);
        }
        public IActionResult Index3()
        {
            var list = new List<Employee>(){
            new Employee(){Id=1,FirstName="Aziz",LastName="Gül",Age=20},
            new Employee(){Id=2,FirstName="Davut",LastName="San",Age=43},
            new Employee(){Id=3,FirstName="Bahtiyar",LastName="Cizzi",Age=35}
            };
            return View("Index3", list);
        }
    }
}