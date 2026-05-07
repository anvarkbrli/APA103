using System.Diagnostics;
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _context;
        public HomeController(AppDBContext context) 
        {
             _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.sliders
                .OrderBy(s => s.Order)
                .Where(s => !s.IsDelete)
                .Take(2)
                .ToList();

            List<Product> products = _context.Products.Where(p=> !p.IsDelete).Include(p=>p.ProductImages).ToList();

            HomeVM homeVM = new()
            {
                Sliders = sliders,
                Products = products
            };

            return View(homeVM);
        }

        
    }
}
