using GerenciadorDeProdutosMVC.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeProdutosMVC.Models;

namespace GerenciadorDeProdutosMVC.Services
{
    public class ServiceProductsRepository
    {
        public ServiceProductsRepository(ProductsContext context) 
        {
            _context = context;
        }
        private readonly ProductsContext _context;

        public List<Product> FindAll()
            => _context.Products.ToList();

        public Product FindById(int? id)
            => _context.Products.FirstOrDefault(x=>x.Id == id);

        public void AddProducts(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = FindById(id);
            _context.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Product obj)
        {
            if (!_context.Products.Any(x => x.Id == obj.Id))
                throw new Exception("Obj not existem in data source");
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }
    }
}
