using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEstoque
{
    internal class Usuario
    {
        public string Nome;
        private double _senha;

        public Usuario(string nome, double senha)
        {
            Nome = nome;
            _senha = senha;
        }
        public double Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if(value > 3)
                {
                    _senha = value;
                }
            }
        }
    }
}
