using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace _25_MVC_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("APA103");
            //var student = new JsonResult(new { Id = 1, name = "Mehemmed", surname = "Memmedov" });
            //return student;
            return View("Index");

        }

        public IActionResult Detail(int? id)
        {
            if (id is null || id < 1)
            {
                return RedirectToAction(nameof(Error));
            }
            return RedirectToAction(nameof(Index), "Product");
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
