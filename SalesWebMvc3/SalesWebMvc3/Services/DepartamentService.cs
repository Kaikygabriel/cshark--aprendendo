using Microsoft.EntityFrameworkCore;
using SalesWebMvc3.Data;
using SalesWebMvc3.Models;

namespace SalesWebMvc3.Services
{
    public class DepartamentService
    {
        public DepartamentService(SalesWebMvc3Context context) 
        {
            _dbContext = context;
        }
        private readonly SalesWebMvc3Context _dbContext;

        public List<Departament> FindAll() 
            => _dbContext.Departament.OrderBy(x=>x.Name).ToList();
    }
}
