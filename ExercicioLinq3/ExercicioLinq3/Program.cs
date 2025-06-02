using System.Globalization;
using ExercicioLinq3.Entities;
using ExercicioLinq3.Service;

namespace ExercicioLinq3;

public class Program
{
    static void Main()
    {
        List<Employ> Funcionarios = new List<Employ>();
        ServicePathEmploy service = new ServicePathEmploy();
        List<string> Liststring = service.Fazer(@"C:\Users\kaiky\Downloads\Funcionario.csv");
        Console.Write("Escreva o valor : R$");
        foreach (var l in Liststring)
        {
            Funcionarios.Add(new Employ(l));
        }
        double priceSalary = double.Parse(Console.ReadLine());
        List<Employ> resu = (
            from p in Funcionarios
            where p.Salary > priceSalary
            select p).ToList();
        foreach (var i in resu)
        {
            Console.WriteLine(i);
        }

        double resu2 = Funcionarios.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();
        Console.WriteLine(resu2);
    }
}