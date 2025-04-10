using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacao
{
    
    internal class Program
    {
        public static List<Candidato> listCandidato = new List<Candidato>();
        public static List<Eleitor> listEleitor = new List<Eleitor>();
        static void Main()
        {
            try
            {
                bool sair = true;
                while (sair)
                {
                    Console.WriteLine("Sistema de votação \n 1- Candidato \n 2- eleitor \n 3- votos \n 4 - sair");

                    int sele = int.Parse(Console.ReadLine());
                    switch (sele)
                    {
                        case 1:
                            Candidato.AdicionarCandidato();
                            break;
                        case 2:
                            Eleitor.AdicionarEleitor();
                            break;
                        case 3:
                            Eleitor.Votar();
                            break;
                        case 4:
                            sair = false;
                            break;
                        default:
                            Console.WriteLine("Erro opção inexistente");
                            break;
                    }
                    Console.Clear();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR, tente novamente");
                Console.ReadLine();
                Console.Clear();
                Main();
            }

        }
    }
}
