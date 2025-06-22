namespace SalesWebMvc3.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string msg):base(msg) 
        { }
    }
}
