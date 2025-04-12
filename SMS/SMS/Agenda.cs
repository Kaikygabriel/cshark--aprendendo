using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsContato
{
    internal class Agenda
    {
        static List<Contato> contatoList =new List<Contato>();
        public static void Adicionar()
        {
            try
            {
                Console.WriteLine("Nome do contato");
                string nome = Console.ReadLine().Trim();
                Console.WriteLine("Numero do contato");
                int numero = int.Parse(Console.ReadLine());
                contatoList.Add(new Contato(nome,numero));
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR");
                Console.Clear();
                Adicionar();
            }

        }
        public static void ExcluirContato()
        {
            try
            {
                if (contatoList.Count > 0)
                {
                    foreach (Contato contato in contatoList)
                    {
                        Console.WriteLine($"O contato {contato.Nome} tem o Numero : {contato.Numero}");
                    }
                    Console.WriteLine("Nome do contato que deseja excluir");
                    string nome = Console.ReadLine();
                    bool achou = false;
                    foreach (Contato contato in contatoList)
                    {
                        if (contato.Nome.Equals(nome))
                        {
                            contatoList.Remove(contato);
                            achou = true;
                            Console.WriteLine("O contato " + contato.Nome + " foi excluido");
                        }
                    }
                    if (achou)
                    {
                        //Acontece nada
                    }
                    else
                    {
                        //da erro
                        Console.WriteLine("Não foi possivel achar o contato " + nome + "\n tente novamente");
                        Console.Clear();
                        ExcluirContato();
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
           catch(Exception e)
           {
                Console.WriteLine("ERROR");
                Console.Clear();
                ExcluirContato();
           }
        }
        public static void VerContatos()
        {
            if (contatoList.Count > 0)
            {
                foreach (Contato contato in contatoList)
                {
                    Console.WriteLine($"O contato {contato.Nome} tem o Numero : {contato.Numero}");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sem contatos");
         
            }
        }
    }
}
