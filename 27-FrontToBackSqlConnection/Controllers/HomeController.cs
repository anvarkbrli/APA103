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
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.sliders
                .OrderBy(s => s.Order)
                .Where(s => !s.IsDelete)
                .Take(2)
                .ToListAsync();

            List<Product> products = await _context.Products
                .Where(p => !p.IsDelete)
                .Include(p => p.ProductImages)
                .ToListAsync();


            HomeVM homeVM = new()
            {
                Sliders = sliders,
                Products = products
            };

            return View(homeVM);
        }

        
    }
}
