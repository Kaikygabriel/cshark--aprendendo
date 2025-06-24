using GerenciadorDeAlunoComCursoMvc.Models;
using GerenciadorDeAlunoComCursoMvc.Service;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeAlunoComCursoMvc.Controllers;

public class CursoController : Controller
{
    public CursoController(ServiceRepositoryCurso repository)
    {
        _repository = repository;
    }

    private readonly ServiceRepositoryCurso _repository;
    
    public async Task<IActionResult> Index()
    {
        var list = await _repository.FindAllAsync();
        return View(list);
    }

    
    public IActionResult Create()
    {
        var curso = new Curso();
        return View(curso);
    }
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(Curso curso)
    {
        if (!ModelState.IsValid)
            return View(curso);

        await _repository.AddRepositoryAsync(curso);
        return RedirectToAction("Index");
    }
    
}