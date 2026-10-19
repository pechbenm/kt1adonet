using Microsoft.AspNetCore.Mvc;

namespace PageApp.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Greet(string name)
        {
            ViewData["Name"] = name;
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string message)
        {
            ViewData["Message"] = message;
            return View("Result");
        }
    }
}