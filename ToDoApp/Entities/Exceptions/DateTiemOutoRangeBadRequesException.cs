namespace Entities.Exceptions
{
    public class DateTiemOutoRangeBadRequesException : BadRequesException
    {
        public DateTiemOutoRangeBadRequesException() :
            base("The date must contain 7 days of date information from today.")
        {

        }
    }
}
