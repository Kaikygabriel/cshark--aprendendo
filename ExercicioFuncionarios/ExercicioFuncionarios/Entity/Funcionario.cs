using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ExercicioFuncionarios.Entity
{
    internal class Funcionario
    {
        public Funcionario() { }

        public Funcionario(double preco, string nome, double horas)
        {
            Preco = preco;
            Nome = nome;
            Horas = horas;
        }

        public double Preco { get;private protected set; }
        public string Nome { get; private protected set; }
        public double Horas { get; private protected set;}
        public virtual void PagarFuncionario()
        {
            double total = Preco * Horas;
            Console.WriteLine($"O funcionario {Nome} vai ter o salario de R${total.ToString("F2")}");
        }
    }
}
