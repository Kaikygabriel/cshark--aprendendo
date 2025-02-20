using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netflix;
using disney
//indica que voce pode usar as classes dentro de neflix
//não precisa mais colocar (Newflix.Filmes apenas colocar Filmes que o csharp ja entende)
namespace ConsoleApp34
{
    internal class Program
    {
        static void Main()
        {
             Netflix.Filme arcane = new Netflix.Filme();
             disney.filme ReiLeao = new disney.filme();
        }
    }
}
namespace disney
{
    class filme
    {

    }
}