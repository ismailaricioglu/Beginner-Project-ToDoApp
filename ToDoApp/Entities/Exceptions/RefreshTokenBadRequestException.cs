namespace Entities.Exceptions
{
    public class RefreshTokenBadRequestException : BadRequesException
    {
        public RefreshTokenBadRequestException()
            : base("Invalid client request. The tokenDto has some invalid values.")
        {
        }
    }
}
