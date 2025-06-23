using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc3.Models
{
    public class Saller
    {

        public Saller() { }

        public Saller(int id, string name, string email, DateTime date, decimal baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(2,ErrorMessage ="Tamanho minimo não atingido")]
        [MaxLength(80, ErrorMessage = "Tamanho maximo atingido")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public Decimal BaseSalary { get; set; }
        [Required]
        public Departament Departament { get; set; }
        public int DepartamentId{ get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public void AddSales(SalesRecord record)
            => Sales.Add(record);
        public void RemoveSales(SalesRecord record)
            => Sales.Remove(record);

        public double TotalSales(DateTime first, DateTime last)
            => Sales.Where(x => x.Date >= first && x.Date <= last).Sum(x => x.Value);
    }
}
