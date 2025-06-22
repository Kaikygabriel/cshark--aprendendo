namespace SalesWebMvc3.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string msg) : base(msg)
        { }
    }
}
