using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class PRoduto
    {
        public string _nome;
        
        public double Valor { get; private set;}


        public PRoduto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade; 
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
            //value indica o valor que vai ser o parametro ex (public string Nome(value){ _nome = value})
        }
    }
}
