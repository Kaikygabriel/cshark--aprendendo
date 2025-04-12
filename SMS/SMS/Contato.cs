using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsContato
{
    internal class Contato
    {
        public string Nome;
        private int _numero;
        public Contato() { }
        public Contato(string nome,int numero)
        {
            
                Nome = nome;
                _numero = numero;
           
        }
        public int Numero
        {
            get { return _numero; }
            set
            {
                if(value == 8 )
                {
                    _numero = value;
                }
            }
        }

        
    }

}
