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

        public async Task<List<Departament>> FindAllAsync() 
            => await _dbContext.Departament.OrderBy(x=>x.Name).ToListAsync();
    }
}
