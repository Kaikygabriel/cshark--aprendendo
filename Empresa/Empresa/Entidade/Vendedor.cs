using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entidade
{
    internal class Vendedor : Funcionario
    {
        public int QuantidadeVendas;
        public Vendedor(string nome, float salario):base(nome,salario){ }
        public void PagarVendedor(float salario , int quantidade)
        {
            Pago = true;
            DateTime DataDePagamento = DateTime.Now;
            //caso a vender mais que 10 recebe um extra de 10 por cento
            if(salario >= Salario)
            {
                if (quantidade > 10)
                {
                    Salario = salario + (salario * 0.1f);

                    Console.WriteLine($"O salario foi pago {DataDePagamento}");
                }
                else
                {
                    Salario = salario;

                    Console.WriteLine($"O salario foi pago {DataDePagamento}");
                }
                Console.WriteLine($"Ficou a mais {salario - this.Salario}");
            }
            else
            {
                if (quantidade > 10)
                {
                    Salario = salario + (salario * 0.1f);

                    Console.WriteLine($"O salario foi pago {DataDePagamento}");
                }
                else
                {
                    Salario = salario;
                    
                    Console.WriteLine($"O salario foi pago {DataDePagamento}");
                }
                Console.WriteLine($"Ficou restando {this.Salario - salario}");
            }
        }
    }
}
