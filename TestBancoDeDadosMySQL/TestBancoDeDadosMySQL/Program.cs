using TestBancoDeDadosMySQL.Entities;
using TestBancoDeDadosMySQL.Entities.Repository;

using (var db = new ServiceRepository())
{
    db.Database.EnsureCreated();
    // Criar um novo produto
    // var produto = new Product("Teclado", 210,2);
    // db.repositoryP.Add(produto);
    // db.SaveChanges(); 

    // Buscar produtos
    var produtos = db.repositoryP.ToList();
    foreach (var p in produtos)
    {
        Console.WriteLine(p);
    }
}