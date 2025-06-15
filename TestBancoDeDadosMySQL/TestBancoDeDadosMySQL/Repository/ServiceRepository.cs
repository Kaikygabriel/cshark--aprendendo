using System;
using Microsoft.EntityFrameworkCore.Design;
using TestBancoDeDadosMySQL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace TestBancoDeDadosMySQL.Entities.Repository;

public class ServiceRepository : DbContext
{
    public DbSet<Product> repositoryP { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql
        (
            "server=localhost;database=bancoTeste;user=root;password=20486501",
            new MySqlServerVersion(new Version(8, 0, 42)) // Versão do MySQL instalada
        );
    }
}