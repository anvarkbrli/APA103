using _27_FrontToBackSqlConnection.Areas.AdminPanel.ViewModels;
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.Utilities.Enums;
using _27_FrontToBackSqlConnection.Utilities.Extensions;
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
        public async Task<IActionResult> Create(SliderCreateVM sliderCreateVM)
        {
            if (!ModelState.IsValid) return View();

            if (!sliderCreateVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "File is incorret!");
                return View();
            }

            if (!sliderCreateVM.Photo.CheckFileSize(FileSize.MB,2))
            {
                ModelState.AddModelError("Photo", "File size must be less  than 2 mb!");
                return View();
            }
            Slider slider = new()
            {
                Title = sliderCreateVM.Title,
                SubTitle = sliderCreateVM.SubTitle,
                Description = sliderCreateVM.Description,
                Order = sliderCreateVM.Order,
                Image = await sliderCreateVM.Photo.CreateFile(_env.WebRootPath, "assets", "images", "website-images")
            };


            await _context.sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.sliders.Where(s=>!s.IsDeleted).FirstOrDefaultAsync(s=>s.Id == id);

            if(slider == null) return NotFound();

            slider.Image.DeleteFile(_env.WebRootPath, "assets", "images", "website-images");

            _context.Remove(slider);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.sliders.Where(s => !s.IsDeleted).FirstOrDefaultAsync(s => s.Id == id);

            if (slider is null) return NotFound();

            SliderUpdateVM sliderUpdateVm = new()
            {
                Title = slider.Title,
                SubTitle = slider.SubTitle,
                Description = slider.Description,
                Order = slider.Order,
                Image = slider.Image,
            };
            

            return View(sliderUpdateVm);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.sliders
                .Where(s => !s.IsDeleted)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (slider is null) return NotFound();

            return View(slider);
        }
    }
}