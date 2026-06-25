using Microsoft.AspNetCore.Mvc;
using ScaffoldingFun.Models;
using System.Diagnostics;


namespace ScaffoldingFun.Controllers
{
    public class HomeController : Controller
    {
        private IBaseballRepository _repo;  //getting a variable of the context file type

        public HomeController(IBaseballRepository temp)   // since the constructor will run automatically we're passing in the context file and set that to our variable above for bigger scope
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            ViewBag.ManagerInfo = _repo.Managers.FirstOrDefault(x => x.PlayerId == "wrighha01");

            return View();
        }
    }
}
