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
            ViewBag.ActivePage = "Dashboard";
            return View();

        }

        public IActionResult CyberSecurityGoverence()
        {
            ViewBag.ActivePage = "CyberSecurityGoverence";
            return View();

        }

        public IActionResult CybersecurityDefense()
        {
            ViewBag.ActivePage = "CybersecurityDefense";
            return View();

        }

        public IActionResult CybersecurityResilience()
        {
            ViewBag.ActivePage = "CybersecurityResilience";

            return View();
        }

        public IActionResult ThirdPartyCybersecurity()
        {
            ViewBag.ActivePage = "ThirdPartyCybersecurity";
            return View();

        }


        public IActionResult CloudComputingCybersecurity()
        {
            ViewBag.ActivePage = "CloudComputingCybersecurity";

            return View();
        }


        public IActionResult ICSCybersecurity()
        {
            ViewBag.ActivePage = "ICSCybersecurity";
            return View();

        }

        public IActionResult Team()
        {
            ViewBag.ActivePage = "Team";
            return View();

        }

        public IActionResult Settings()
        {
            ViewBag.ActivePage = "Settings";
            return View();

        }


    }

    public class SettingsController : Controller
    {

        public IActionResult General()
        {
            ViewBag.ActivePage = "General";
            return View();

        }




        public IActionResult Security()
        {
            ViewBag.ActivePage = "Security";
            return View();

        }


        public IActionResult Account()
        {
            ViewBag.ActivePage = "Account";
            return View();

        }


        public IActionResult Plan()
        {
            ViewBag.ActivePage = "Plan";
            return View();

        }



        public IActionResult Notification()
        {
            ViewBag.ActivePage = "Notification";
            return View();

        }




    }


}
