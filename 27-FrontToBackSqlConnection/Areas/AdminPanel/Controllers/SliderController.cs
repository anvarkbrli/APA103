using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private readonly AppDBContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDBContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.sliders
                .Where(s => !s.IsDeleted)
                .ToListAsync();

            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            if (!slider.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError(nameof(Slider.Photo), "File is incorret!");
                return View();
            }

            if (slider.Photo.Length > 2 * 1024 * 1024)
            {
                ModelState.AddModelError(nameof(Slider.Photo), "File is too large!");
                return View();
            }

            string fileName = string.Concat(Guid.NewGuid().ToString(), slider.Photo.FileName);
            string path = Path.Combine(_env.WebRootPath, "assets", "images", "website-images", fileName);

            FileStream fileStream = new FileStream(path, FileMode.Create);

            await slider.Photo.CopyToAsync(fileStream);
            fileStream.Close();
            slider.Image = fileName;

            await _context.sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}