using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
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
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var listUsuario = await _context.FindAllAsync();
        return View(listUsuario);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Usuario usuario)
    {
        if (!ModelState.IsValid)
            return View(usuario);
        
        await _context.AddUsuarioAsync(usuario);
        return RedirectToAction("Index");
    }
    [HttpGet]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
            return RedirectToAction("Error");
        var usuario = await _context.FindByIdAsync((int)id); 
        if (usuario == null)
            return RedirectToAction("Error");

        return View(usuario); 
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _context.RemoveAsync(id);
            return RedirectToAction("Index");
        }
        catch (ApplicationException e)
        {
            TempData["Erro"] = e.Message;
            return NotFound();
        }
    }

    public IActionResult Error()
    {
        return View();
    }
}