namespace Elearn_BackEnd.Models
{
    public class CourseAuthor : BaseEntity
    {
        public string FullName { get; set; }
        public string AuthorImage { get; set; }
        ICollection<Course> Courses { get; set; }
    }
}
