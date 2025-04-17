using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entidade
{
    internal class Funcionario
    {
        
        public bool Pago;
        public float Salario;

        public Funcionario(string nome, float salario)
        {
            Nome = nome;
            Salario = salario;
            Pago = false;
        }
        public string Nome { get; private set; }
    }
}
