using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeAlunoComCursoMvc.Models;

public class Curso
{
    public Curso(){}

    public Curso(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MinLength(3,ErrorMessage = "error, the course does not have 4 letters")]
    [MaxLength(80,ErrorMessage = "error, the course has more than 80 letters")]
    public string Name { get; set; }
    
    [Required] 
    public decimal Price{ get; set; }
}