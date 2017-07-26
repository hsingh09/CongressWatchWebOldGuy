using Microsoft.AspNetCore.Mvc;

namespace CongressWatchWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "CongressWatch web client";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
