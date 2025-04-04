using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionario
{
    internal class Funcionario
    {
        public string Nome;
        public int Id;
        public float Salario;
        public Funcionario(string nome, float salario,int id)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public override string ToString()
        {
            return $"Funcionario {Nome}, tem o id {Id} eo salario de R${Salario}";
        }
        public void adiconar(float porcentagem)
        {
            float por = Salario*(porcentagem / 100);
            Salario += por;
        }
    }
}
