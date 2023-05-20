using Elearn_BackEnd.Areas.Admin.ViewModels;
using Elearn_BackEnd.Areas.Admin.ViewModels.TopSlider;
using Elearn_BackEnd.Data;
using Elearn_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Elearn_BackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TopSliderController : Controller
    {
        private readonly AppDbContext _context;

        public TopSliderController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<TopSliderVM> list = new();

            IEnumerable<TopSlider> topSliders = await _context.TopSliders.Where(m => !m.SoftDelete).ToListAsync();

            foreach (TopSlider slider in topSliders)
            {
                TopSliderVM model = new()
                {
                    Id = slider.Id,
                    Logo = slider.Logo,
                    Title = slider.Title,
                    Description = slider.Description,
                    CreatedDate = slider.CreateDate.ToString("MMMM dd, yyyy"),
                    Status = slider.SoftDelete,
                };

                list.Add(model);
            }

            return View(list);
        }


        [HttpGet]

        public async Task<IActionResult> Detail(int? id)
        {

            if (id is null) return BadRequest();

            TopSlider dbSlider = await _context.TopSliders.FirstOrDefaultAsync(m => m.Id == id);

            if (dbSlider is null) return NotFound();

            TopSliderDetailVM model = new()
            {
                Logo = dbSlider.Logo,
                Title = dbSlider.Title,
                CreatedDate = dbSlider.CreateDate.ToString("MMMM dd, yyyy"),
                Status = dbSlider.SoftDelete,
                Description = dbSlider.Description,
            };
            return View(model);
        }


    }
}
