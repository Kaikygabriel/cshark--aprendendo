using BibioteclaOOP.Entity;
using BibioteclaOOP.Entity.InterfaceEntity;

namespace BibioteclaOOP.Service
{
    public sealed class Emprestimo
    {
        public Emprestimo() { }
        public Emprestimo(Usuario usuario, Ilivro livro, DateTime entregaData)
        {
            Usuario = usuario;
            Livro = livro;
            EntregaData = entregaData;
        }

        public Usuario Usuario { get; private set; }
        public Ilivro Livro { get; private set; }
        public DateTime EmprestimoData { get; private set; } = DateTime.Now;
        public DateTime EntregaData { get; private set; }

        public void GetEmprestimo()
        {
            Console.WriteLine(Livro);
            Console.WriteLine(Usuario);
        }
    }
}