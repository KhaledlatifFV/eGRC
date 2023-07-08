using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace task1._3.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Dashboard()
        {
            return View();

        }

        public IActionResult CyberSecurityGoverence()
        {
            return View();

        }

        public IActionResult CybersecurityDefense()
        {
            return View();

        }

        public IActionResult CybersecurityResilience()
        {
            return View();
        }

        public IActionResult ThirdPartyCybersecurity()
        {
            return View();

        }


        public IActionResult CloudComputingCybersecurity()
        {
            return View();
        }


        public IActionResult ICSCybersecurity()
        {
            return View();

        }

        public IActionResult Settings()
        {
            return View();

        }

    }

}
