using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logarSistema;

namespace logarSistema
{
    internal class Program
    {
        enum op {g = 1,f}
        enum g { ver = 1,criar}
        static void Main()
        {

            Console.WriteLine("Crie sua Conta\n 1-Google \n 2- Facebook");
            op sele = (op)int.Parse(Console.ReadLine());
            switch (sele)
            {
                case op.g:
                    Console.Clear();
                    Console.WriteLine("1 - ver \n 2-criar");
                    g seleg = (g)int.Parse(Console.ReadLine());
                    switch (seleg)
                    {
                        case g.criar:
                            Console.WriteLine("escreva o email");
                            string email = Console.ReadLine();
                            Console.WriteLine("escreva o nome");
                            string nome = Console.ReadLine();
                            Console.WriteLine("escreva o senha (SOMENTE NUMERO)");
                            int senha = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Usuario.logar(senha, email, nome);
                            break;
                        case g.ver:
                            Console.Clear();
                            Usuario.verGoogle();
                            break;
                        default:
                            Console.Write("nada encontrado");
                            break;
                    }

                    break;
                default:
                    Console.Write("nada encontrado");
                    break;
            }
        }
    }
}
