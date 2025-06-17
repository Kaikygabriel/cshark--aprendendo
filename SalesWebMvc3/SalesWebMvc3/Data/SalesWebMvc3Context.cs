using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc3.Models;

namespace SalesWebMvc3.Data
{
    public class SalesWebMvc3Context : DbContext
    {
        public SalesWebMvc3Context (DbContextOptions<SalesWebMvc3Context> options)
            : base(options)
        {
        }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Saller>Saller { get; set; }
        public DbSet<Departament> Departament { get; set; } 
    }
}
