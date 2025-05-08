using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassandoArquivo.Entity
{
    internal sealed class Item
    {
        public Item() { }

        public Item(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public string Nome { get; private set; }
        public double Valor{ get; private set; }
        public int Quantidade{ get; private set; }
        public double ValorTotal()
        {
            return Valor * Quantidade;
        }
        public override string ToString()
        {
            return $"{Nome} tem o valor de {Valor} ea quantidade de {Quantidade}";
        }
    }
}
