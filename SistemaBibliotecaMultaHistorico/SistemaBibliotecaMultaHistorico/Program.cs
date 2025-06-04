using SistemaBlibiotecaMulta.Entities;
using SistemaBlibiotecaMulta.ExtesionMethods;
using SistemaBlibiotecaMulta.Service;

namespace SistemaBlibiotecaMulta;
 public class Program
 {
     static void Main()
     {
         Usuario kaiky = new Usuario("Kaiky");
         Livro Blibia = new Livro("Blibia", "Deus", true);
         Livro SegredosMenteM = new Livro("Segredos da mente milionaria", "harv", true);
         Blibioteca blibiotecaSuzano = new Blibioteca(new ServiceRepositoryLivroTxt());

         ServiceEmprestimo serviceE = new ServiceEmprestimo();
         
         blibiotecaSuzano.AddLivro(Blibia);
         blibiotecaSuzano.AddLivro(SegredosMenteM);
         
         serviceE.AddEmprestimo(Blibia,kaiky,DateTime.Now, DateTime.Now.AddDays(12),blibiotecaSuzano);
         serviceE.AddEmprestimo(SegredosMenteM,kaiky,DateTime.Now, DateTime.Now.AddDays(20),blibiotecaSuzano);
        
         blibiotecaSuzano.Emprestimos.GetList();
     }
 }