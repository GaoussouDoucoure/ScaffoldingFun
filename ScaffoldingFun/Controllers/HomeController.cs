using Microsoft.AspNetCore.Mvc;
using ScaffoldingFun.Models;
using System.Diagnostics;


namespace ScaffoldingFun.Controllers
{
    public class HomeController : Controller
    {
        private Lahman18712022Context context;  //getting a variable of the context file type

        public HomeController(Lahman18712022Context temp)   // since the constructor will run automatically we're passing in the context file and set that to our variable above for bigger scope
        {
            context = temp;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
