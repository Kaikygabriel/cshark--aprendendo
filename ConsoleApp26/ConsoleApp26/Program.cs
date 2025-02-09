using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp26
{
    internal class Program
    {
        static void Main()
        {
            aluno kaiky = new aluno("manha",000111773855,"kaiky","kaiky@gmail.com");
            Usuario kg = new aluno("manha", 000111773855, "kaiky", "kaiky@gmail.com");
            //as variaveis que herdam(pai == usuario) pode receber os filhos que estão herdano(aluno)
            //quando salva uma variavel do tipo pai, no tipo filho, não da para acessar as instancias referente ao aluno
            //da pra converter variaveis do tipo pai para tipo filho (Casting)
            //so pode trabalhar com casting quando tem a certeza que eo mesmo tipo que voce quer converter
            Console.WriteLine(((aluno)kg).periodo);
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add( new aluno("manha", 000111773855, "kaiky", "kaiky@gmail.com"));
            usuarios.Add(new aluno("tarde", 000111333444, "kg", "kg@gmial.com"));
            
            kaiky.exibir();
            //exibir(string string)
            kaiky.exibir(kaiky.email, "123kaiky");
            //exibir(void)
            
                
            Console.WriteLine(usuarios.Count); 





        }
    }
}
