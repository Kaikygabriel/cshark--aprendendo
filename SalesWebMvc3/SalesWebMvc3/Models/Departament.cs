using System.Collections;

namespace SalesWebMvc3.Models
{
    public class Departament
    {
        public Departament() { }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name{ get; set; }
        public ICollection<Saller> Sallers { get; set; }= new List<Saller>();
        public void AddSaller(Saller saler)
            => Sallers.Add(saler);
        public double TotalSales(DateTime first,DateTime last)
            => Sallers.Sum(x => x.TotalSales(first, last));
    }
}
