using LoginMvc.Data;
using LoginMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginMvc.Services;

public class ServiceRepositoryLogin
{
    private readonly LoginMvcDbContext _context;

    public ServiceRepositoryLogin(LoginMvcDbContext context)
    {
        _context = context;
    }

    public async Task<List<Usuario>> FindAllAsync()
        => await _context.Usuarios.ToListAsync();

    public bool ExisteEmail(string email)
        => _context.Usuarios.Any(x => x.Email == email);
    public bool ExisteName(string nome)
        => _context.Usuarios.Any(x => x.Name == nome);

    public async Task AddUsuarioAsync(Usuario usuario)
    {
        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();
    }

    public async  Task<Usuario> FindByIdAsync(int id)
        => await  _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
    public bool Exite(int id)
        => _context.Usuarios.Any(x => x.Id == id);
    public async Task RemoveAsync(int id)
    {
        try
        {
            if (!Exite(id))
            {
                throw new ApplicationException("Error usuario não existe");
            }

            var usuario =  await FindByIdAsync(id);
            
            _context.Remove(usuario);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }
    }
}