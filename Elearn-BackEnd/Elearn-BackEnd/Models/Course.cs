namespace Elearn_BackEnd.Models
{
    public class Course : BaseEntity
    {
        public string Tag { get; set; }
        public double price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SaleCount { get; set; }
        public ICollection<CourseImage> Images { get; set; }
        public int AuthorId { get; set; }
        public CourseAuthor Author { get; set; }
    }
}
