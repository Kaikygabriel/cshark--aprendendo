using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos
{
    internal class Program
    {
        static void Main()
        {
            Aluno a = new Aluno();
            //filho herda todas as caracteristicas do pai, porem o pai não herda as caracteristica do filho!!!
            a.email = "kaiky@gmail.com";
            a.nome = "kaiky";
            a.logar();
        }
    }
}
