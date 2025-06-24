using GerenciadorDeAlunoComCursoMvc.Data;
using GerenciadorDeAlunoComCursoMvc.Models;

namespace GerenciadorDeAlunoComCursoMvc.Service;

public class SeedingServiceCurso
{
    public SeedingServiceCurso(CursoDbContext context)
    {
        _context = context;
    }

    private readonly CursoDbContext _context;

    public void Seed()
    {
        if (_context.Cursos.Any())
            return;
        var c1 = new Curso(1, "Curso de logica de programação", 200);
        var c2 = new Curso(2, "Curso Programação Orientada a Objeto", 600);
        _context.AddRange(c1,c2);
        _context.SaveChanges();
    }
}