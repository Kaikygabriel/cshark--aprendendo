using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main()
        {
            Professor alan = new Professor("fisica", "alan", "alan@gmail", "123alan");
            Professor.sla();
            Aluno kaiky = new Aluno("3c", "Kaiky", "kaiky@gamil.com", "123");
            kaiky.exibir();
        }
    }
}
