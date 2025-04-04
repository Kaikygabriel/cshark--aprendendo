using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionarFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario kaiky = new Funcionario("Kaiky Gabriel", 7000f);
            kaiky.exibir();
        }
    }
}
