using System.ComponentModel.DataAnnotations;
using LoginMvc.Atribustes;

namespace LoginMvc.Models;

public class Usuario
{
    public Usuario(){}

    public Usuario(int id, string name, string email, string password)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
    }

    [Key]
    [Required(ErrorMessage = "Id é Obrigatorio")]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100,MinimumLength = 3,ErrorMessage = "Limite é entre 3 e 100 caracters")]
    [NameInUse]
    public string Name { get; set; }
    
    [Required]
    [EmailAddress]
    [EmailInUse]
    public string Email { get; set; }
    
    [Required]
    [StringLength(40,MinimumLength = 8,ErrorMessage = "Limite é entre 8 e 40 caracters")]
    public string Password { get; set; }
}