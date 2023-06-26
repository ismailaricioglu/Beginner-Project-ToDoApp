namespace Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Text { get; set; }
        public DateTime DateTime { get; set; }

        // ref : navigation property
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
