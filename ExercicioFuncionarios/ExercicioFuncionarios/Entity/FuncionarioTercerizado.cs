using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionarios.Entity
{
    sealed class FuncionarioTercerizado : Funcionario
    {
        public FuncionarioTercerizado() { }
        public FuncionarioTercerizado(double valorInicial,string nome,double salario,double horas ):base(salario,nome,horas)
        {
            ValorInicial = valorInicial;
        }

        public double ValorInicial { get; private set; }
        public override void PagarFuncionario()
        {
            double total = (Horas * Preco) + ((ValorInicial * 0.10) + ValorInicial);
            Console.WriteLine($"O funcionario {Nome} vai ter o salario de R${total.ToString("F2")}");
        }
    }
}
