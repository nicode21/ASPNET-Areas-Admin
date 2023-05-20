using Elearn_BackEnd.Data;
using Elearn_BackEnd.Models;
using Elearn_BackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elearn_BackEnd.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.Images).Include(m => m.Author).Where(m => !m.SoftDelete).Take(3).ToListAsync();
            int count = await _context.Courses.Include(m => m.Images).Include(m => m.Author).Where(m => !m.SoftDelete).CountAsync();
            ViewBag.Count = count;

            HomeVM home = new()
            {
                Courses = courses
            };

            return View(home);
        }

        public async Task<IActionResult> ShowMore(int skip)
        {
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.Images).Include(m => m.Author).Where(m => !m.SoftDelete).Take(3).ToListAsync();

            return PartialView("_CoursesPartial", courses);
        }
    }
}
