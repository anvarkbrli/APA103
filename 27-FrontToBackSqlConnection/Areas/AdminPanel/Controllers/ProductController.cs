using _27_FrontToBackSqlConnection.Areas.AdminPanel.ViewModels;
using _27_FrontToBackSqlConnection.Areas.AdminPanel.ViewModels.Products;
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly AppDBContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDBContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<ProductGetVM> productGetVMs = await _context.Products
            .Where(p => !p.IsDeleted)
            .Include(p => p.ProductImages)
            .Include(p => p.Category)
            .Select(p => new ProductGetVM
             {
              Id = p.Id,
              Name = p.Name,
              CategoryName = p.Category.Name,
              Price = p.Price,
              SKU = p.SKU,
              Image = p.ProductImages.FirstOrDefault().Image,
            })
            .ToListAsync();

            return View(productGetVMs);
        }
        public async Task<IActionResult> Create()
        {
            ProductCreateVM productCreateVM = new()
            {
                Categories = await _context.Categories.Where(c => !c.IsDeleted).ToListAsync()
            };
            return View(productCreateVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateVM productCreateVM)
        {
            productCreateVM.Categories = await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();

            if(ModelState.IsValid) return View(productCreateVM);

            bool existsCategory = productCreateVM.Categories.Any(c => c.Id == productCreateVM.CategoryId);

            if (!existsCategory)
            {
                ModelState.AddModelError(nameof(productCreateVM.CategoryId), "Category does not exist");
            }

            Product product = new()
            {
                Name = productCreateVM.Name,
                Price = productCreateVM.Price,
                Description = productCreateVM.Description,
                SKU = productCreateVM.SKU,
                CategoryID = productCreateVM.CategoryId.Value
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Category existCategory = await _context.Categories
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (existCategory is null) return NotFound();

            return View(existCategory);
        }
    }
}
