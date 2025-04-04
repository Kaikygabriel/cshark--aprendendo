using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionarFuncionarios
{
    internal class Funcionario
    {

        public string Nome;
        public float Salario;
        public float Imposto;
        public Funcionario(string nome, float salario)
        {
            this.Nome = nome;
            this.Salario = salario;
            if (salario <= 1.908)
            {
                this.Imposto = 0;
            }
            else if(salario <= 2.800 && salario >= 1.909)
            {
               
                this.Imposto = salario * 0.75f;
                Salario = salario - (salario * 0.75f);
            }
            else
            {
                this.Imposto = salario * 0.115f;
                this.Salario =  salario - (salario * 0.115f);
            }
         
        }
        public void exibir()
        {
            Console.WriteLine($"O Funcionario {Nome}, tem o salario de {Salario}, com imposto de {Imposto}");
        }
    }
}
