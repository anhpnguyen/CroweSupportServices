using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CroweSupportServices.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Crowe Horwath Support Services";
            return View();
        }
        public IActionResult MyAccount()
        {
            return View();
        }

        public IActionResult AccountHistory()
        {
            return View();
        }

        public IActionResult HelpCenter()
        {
            return View();
        }

    }
}
