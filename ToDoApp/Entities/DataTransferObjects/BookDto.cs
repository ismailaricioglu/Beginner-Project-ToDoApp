namespace Entities.DataTransferObjects
{
    public record BookDto
    {
        public int Id { get; init; }
        public String Text { get; init; }
        public DateTime DateTime { get; init; }
        public int CategoryId { get; init; }
    }
}
