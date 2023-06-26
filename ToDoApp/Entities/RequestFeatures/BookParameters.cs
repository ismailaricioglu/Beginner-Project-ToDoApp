namespace Entities.RequestFeatures
{
    public class BookParameters : RequestParameters
    {
        //public uint MinPrice { get; set; }
        //public uint MaxPrice { get; set; } = 1000;
        //public bool ValidPriceRange => MaxPrice > MinPrice;

        public DateTime MinDateTime { get; set; } //= DateTime.UtcNow;
        public DateTime MaxDateTime { get; set; } = DateTime.UtcNow.AddDays(7);
        public bool ValidDateTimeRange => MaxDateTime > MinDateTime;
        public int CategoryId { get; set; } = -1;

        public String? SearchTerm { get; set; }

        public BookParameters()
        {
            OrderBy = "id";
        }
    }
}
