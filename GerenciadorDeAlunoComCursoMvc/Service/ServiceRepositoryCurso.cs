using GerenciadorDeAlunoComCursoMvc.Data;
using GerenciadorDeAlunoComCursoMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeAlunoComCursoMvc.Service;

public class ServiceRepositoryCurso
{
    public ServiceRepositoryCurso(CursoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    private readonly CursoDbContext _dbContext;

    public async Task<List<Curso>> FindAllAsync()
        => await _dbContext.Cursos.ToListAsync();

    public async Task AddRepositoryAsync(Curso curso)
        =>  await _dbContext.AddAsync(curso);
    
}