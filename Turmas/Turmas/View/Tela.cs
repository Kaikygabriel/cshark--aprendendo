using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turmas.Telas
{
    internal class Tela
    {
        public static void TelaInicial()
        {
            bool sair = true;
            while (sair)
            {
                Console.WriteLine("1- adicionar aluno \n 2- listar aluno \n -3 sair");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Turmas.Contorler.Funções.Adicionar();
                        break;
                    case 2:
                        Turmas.Contorler.Funções.Listar();
                        break;
                    case 3:
                        sair = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
