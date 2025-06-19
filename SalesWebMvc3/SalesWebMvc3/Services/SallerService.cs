using Microsoft.EntityFrameworkCore;
using SalesWebMvc3.Data;
using SalesWebMvc3.Models;

namespace SalesWebMvc3.Services
{
    public class SallerService
    {
        public SallerService(SalesWebMvc3Context dbContext)
        {
            _dbcontext = dbContext;
        }

        private readonly SalesWebMvc3Context _dbcontext;

        public List<Saller> FindAll()
            => _dbcontext.Saller.ToList();

        public void AddSallerRepository(Saller saller)
        {
            saller.Departament = _dbcontext.Departament.ToList()[0];
            _dbcontext.Add(saller);
            _dbcontext.SaveChanges();
        }
    }
}
