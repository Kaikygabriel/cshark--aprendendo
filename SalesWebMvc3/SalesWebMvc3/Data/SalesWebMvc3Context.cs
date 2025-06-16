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

        public DbSet<SalesWebMvc3.Models.Departament> Departament { get; set; } 
    }
}
