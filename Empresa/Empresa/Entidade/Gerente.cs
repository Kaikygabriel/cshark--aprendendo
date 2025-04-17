using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entidade
{
    internal class Gerente:Funcionario
    {
        
        public int QuantidadeDeVendas;
        public Gerente(string nome, float salario , int id) : base(nome, salario)
        {
            Id = id;    
        }
        public int Id { get; private set; }
        public void PagarGerente(float salario, int quantidade)
        {
            Pago = true;
            DateTime PagamentoData = DateTime.Now;
            //caso for maior ou igual a 100 recebe extra
            if(quantidade >= 100)
            {
                Salario = salario + (salario * 0.1f);
                Console.WriteLine($"O salario foi pago {PagamentoData}");
            }
            else
            {
                Salario = salario;
                Console.WriteLine($"O salario foi pago {PagamentoData}");
            }
        }
    }
}
