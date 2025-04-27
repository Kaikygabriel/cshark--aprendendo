using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioFuncionarios.Entity;

namespace ExercicioFuncionarios.Controler
{
    internal class Function
    {
        static List<Funcionario> funcionarios = new List<Funcionario>();
        public static void AdicionarFuncionario()
        {
            Console.Write("Nome :");
            string nome = Console.ReadLine().Trim();
            Console.Write("Horas :");
            double horas = double.Parse(Console.ReadLine().Trim());
            Console.Write("Salario :");
            double salario = double.Parse(Console.ReadLine().Trim()); 
            funcionarios.Add(new Funcionario(salario,nome,horas));
        } 
        public static void AdicionarFuncionarioTerceiro()
        {
            Console.Write("Nome :");
            string nome = Console.ReadLine().Trim();
            Console.Write("Horas :");
            double horas = double.Parse(Console.ReadLine().Trim());
            Console.Write("Salario :");
            double salario = double.Parse(Console.ReadLine().Trim());
            Console.Write("Salario primario:");
            double salarioPrimario = double.Parse(Console.ReadLine());
            funcionarios.Add(new FuncionarioTercerizado(salarioPrimario,nome,salario,horas));
        }
        public static void ListarFuncionario()
        {
            foreach(Funcionario f in funcionarios)
            {
                f.PagarFuncionario();
            }
        }
    }
}
