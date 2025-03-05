using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando
{
    internal class Cep
    {
        public string cep;
        public string logradouro;
        public string bairro;
        public string estado;
        public int ddd;
        public void exibir()
        {
            Console.WriteLine($"Seu cep  é : {cep}\n Voce esta no logradouro{logradouro} \n È do bairro {bairro} \n do Estado de {estado} eo ddd {ddd}");
        }
    }
}
