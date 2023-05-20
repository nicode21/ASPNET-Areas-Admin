using Elearn_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace Elearn_BackEnd.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){}

        public DbSet<TopSlider> TopSliders { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Accordion> Accordions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourchesImages { get; set; }
        public DbSet<CourseAuthor> CourchesAuthor { get; set; }

    }
}
