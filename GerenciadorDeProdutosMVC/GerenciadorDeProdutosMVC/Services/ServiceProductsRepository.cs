using GerenciadorDeProdutosMVC.Data;
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

        public void AddProducts(Product product)
            => _context.Add(product);
    }
}
