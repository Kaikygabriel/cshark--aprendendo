using LoginMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginMvc.Data;

public class LoginMvcDbContext : DbContext
{
    public LoginMvcDbContext(DbContextOptions<LoginMvcDbContext> options) : base(options)
    {
        
    }
    public DbSet<Usuario> Usuarios { get; set; }
}