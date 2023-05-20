using Elearn_BackEnd.Models;

namespace Elearn_BackEnd.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<TopSlider> TopSliders { get; set; }
        public IEnumerable<Milestone> Milestones { get; set; }
        public IEnumerable<Accordion> Accordions { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<New> News { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
