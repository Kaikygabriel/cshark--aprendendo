namespace SalesWebMvc3.Models.ViewModels
{
    public class SallerFormViewModel
    {
        public SallerFormViewModel() { }
        public Saller Saller { get; set; }
        public ICollection<Departament>Departaments { get; set; }

    }
}
