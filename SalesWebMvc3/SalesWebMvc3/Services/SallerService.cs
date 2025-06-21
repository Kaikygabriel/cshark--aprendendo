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

        public Saller FindById(int? Id)
            => _dbcontext.Saller.Include(obj => obj.Departament).FirstOrDefault(x=>x.Id == Id);

        public void Remove(int Id)
        {
            var obj = FindById(Id);
            _dbcontext.Saller.Remove(obj);
            _dbcontext.SaveChanges();
        }

        public void AddSallerRepository(Saller saller)
        {
            _dbcontext.Add(saller);
            _dbcontext.SaveChanges();
        }
    }
}
