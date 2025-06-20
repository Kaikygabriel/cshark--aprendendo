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

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public Decimal BaseSalary { get; set; }
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
