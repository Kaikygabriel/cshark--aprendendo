using LoginMvc.Models;
using LoginMvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoginMvc.Controllers;

public class UsuarioController : Controller
{
    public UsuarioController(ServiceRepositoryLogin context)
    {
        _context = context;
    }

    private readonly ServiceRepositoryLogin _context;

    public async Task<IActionResult> Index()
    {
        var listUsuario = await _context.FindAllAsync();
        return View(listUsuario);
    }
    
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(Usuario usuario)
    {
        if (!ModelState.IsValid)
            return View(usuario);
        
        await _context.AddUsuarioAsync(usuario);
        return RedirectToAction("Index");
    }

}