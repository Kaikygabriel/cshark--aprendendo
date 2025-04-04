using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBlibiotecaw
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1-Blibioteca\n2- clientes ");
            Blibioteca.AdicionarLivros();
            Usuario.AdicionarCliente();
            Blibioteca.usuarios[0].AdicionarLivro();
            Blibioteca.usuarios[0].RemoverLivro();


        }
    }
}
