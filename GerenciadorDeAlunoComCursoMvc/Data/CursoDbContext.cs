using GerenciadorDeAlunoComCursoMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeAlunoComCursoMvc.Data;

public class CursoDbContext : DbContext
{
    public CursoDbContext(DbContextOptions<CursoDbContext> options) : base(options)
    {
        
    }
    public DbSet<Curso> Cursos { get; set; }
    
}