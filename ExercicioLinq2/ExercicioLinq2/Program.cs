using System.Globalization;
using System.Collections.Generic;
using ExercicioLinq2.Entities;
using ExercicioLinq2.Service;

namespace ExercicioLinq2;

public class Program
{
    public static void Main()
    {
        ServicePath service = new ServicePath();
        List<Employ> listEmploy = new List<Employ>();
        List<string> list = service.Pegar(@"C:\Users\kaiky\Downloads\Funcionario.csv");
        foreach (var l in list)
        {
            listEmploy.Add(new Employ(l));
        }

        Console.Write("Enter Salary : R$");
        double salaryTeste = double.Parse(Console.ReadLine());

        Console.WriteLine($"List email of people whose  salary is more than {salaryTeste.ToString("F2")}");
        var resu =
            (from p in listEmploy
                where p.Salary > salaryTeste
                select p.Email).OrderBy(x => x);
        foreach (var r in resu)
        {
            Console.WriteLine(r);
        }

        var resu2 = listEmploy.Where(x => x.Nome[0] == 'M').Select(x => x.Salary).Sum();
        Console.WriteLine($"salary total dos que começa com m {resu2.ToString("F2")}");
    }
}