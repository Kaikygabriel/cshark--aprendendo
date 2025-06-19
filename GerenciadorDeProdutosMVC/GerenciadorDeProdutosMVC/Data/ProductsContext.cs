using GerenciadorDeProdutosMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GerenciadorDeProdutosMVC.Data
{
    public class ProductsContext  : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options)
            : base(options)
        {
        
        }
        public DbSet<Product> Products { get; set; }
    }
}
