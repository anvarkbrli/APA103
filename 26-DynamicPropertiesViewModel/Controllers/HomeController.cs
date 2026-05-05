using _26_DynamicPropertiesViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _26_DynamicPropertiesViewModel.Controllers
{
    
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>
        {
        new Student{Id = 1, Name = "Cabbar" , Age = 19},
        new Student{Id = 2, Name = "Eli" , Age = 20},
        new Student{Id = 3, Name = "Sebine" , Age = 19}
        };

        private List<Teacher> teachers = new List<Teacher>
        {
        new Teacher { Id = 1, Name = "Ali", Salary = 300 },
        new Teacher { Id = 2, Name = "Eyyub", Salary = 200 }
        };

        public IActionResult Index()
        {
            //ViewBag.Students = students;
            //ViewData["Students"] = students;
            //TempData["Name"] = "Cabbar";

            HomeVM homeVM = new()
            {
                Teachers = teachers,
                Students = students,
            };

            return View(homeVM);
        }

        public IActionResult Details(int id)
        {
            return View(students[id]);
        }
        [Route("korporative-satislar")]
        public IActionResult CorporativeSales()
        {
            return View();
        }
    }
}
