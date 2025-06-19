using GerenciadorDeProdutosMVC.Data;
using GerenciadorDeProdutosMVC.Models;

namespace GerenciadorDeProdutosMVC.Services
{
    public class SeedingProducts
    {
        public SeedingProducts(ProductsContext context)
        {
            _context = context;
        }
        private readonly ProductsContext _context;

        public void Seed()
        {
            if (_context.Products.Any())
                return;
            var mouse = new Product(1, "mouse Multilase", 80, 10);
            var teclado = new Product(2, "teclado Reddragon", 180, 7);

            _context.AddRange(mouse, teclado);
            _context.SaveChanges();
        }
        
    }
}
