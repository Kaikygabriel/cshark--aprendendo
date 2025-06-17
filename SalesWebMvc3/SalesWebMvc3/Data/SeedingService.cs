using System.Globalization;
using SalesWebMvc3.Models;
using SalesWebMvc3.Models.Enums;

namespace SalesWebMvc3.Data
{
    public class SeedingService
    {
        private SalesWebMvc3Context _context;
        public SeedingService(SalesWebMvc3Context context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departament.Any() ||
                _context.Saller.Any() ||
                _context.SalesRecord.Any())
                return;

            
            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronics");

            Saller s1 = new Saller(1, "Kaiky", "kaiky@gmail.com", new DateTime(2008, 3, 16), 2000, d1);
            Saller s2 = new Saller(2, "Gabriel", "gabriel@gmail.com", new DateTime(2009, 3, 16), 1700, d2);

            _context.Departament.AddRange(d1, d2);
            _context.Saller.AddRange(s1, s2);
            _context.SaveChanges(); 

            SalesRecord r1 = new SalesRecord(1, new DateTime(2025, 5, 2), 130, ESalesStatus.Peding, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2025, 5, 1), 200, ESalesStatus.Billed, s2);

            _context.SalesRecord.AddRange(r1, r2);
            _context.SaveChanges();
        }
    }
}
