using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando
{
    internal class Produto
    {
        public string nome;
        public virtual void exibir()
        {
            Console.WriteLine($"Nome do Produto é {nome}");
        }
    }
    interface
}
