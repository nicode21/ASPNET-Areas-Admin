using Elearn_BackEnd.Data;
using Elearn_BackEnd.Models;
using Elearn_BackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Elearn_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<TopSlider> topSliders = await _context.TopSliders.Where(m=>!m.SoftDelete).ToListAsync();
            IEnumerable<Milestone> milestones = await _context.Milestones.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.Images).Include(m => m.Author).Where(m => !m.SoftDelete).Take(3).ToListAsync();
            IEnumerable<Accordion> accordions = await _context.Accordions.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Event> events = await _context.Events.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<New> news= await _context.News.Where(m => !m.SoftDelete).ToListAsync();


            HomeVM home = new()
            {
                TopSliders = topSliders,
                Milestones = milestones,
                Accordions = accordions,
                Events = events,
                News = news,
                Courses= courses
            };

            return View(home);
        }
    }
}