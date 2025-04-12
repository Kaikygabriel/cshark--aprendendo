using System.Runtime.CompilerServices;
using SmsContato;

namespace SMS
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool sair = true;
            while (sair)
            {
                Console.WriteLine("1- Adicionar Contato \n2- Ver contatos \n3-remover contaots \n4- Sair");
                int sele = int.Parse(Console.ReadLine());
                switch (sele)
                {
                    case 1:
                        Agenda.Adicionar();
                        break;
                    case 2:
                        Agenda.VerContatos();
                        break;
                    case 3:
                        Agenda.ExcluirContato();
                        break;
                    case 4:
                        sair = false;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
