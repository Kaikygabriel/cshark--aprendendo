
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaçadorDEPalavrasPalindromas
{
    internal class Program
    {
        static void Main(string[] args)
        { 

             Palavraspalindromos();
        }
        static void Palavraspalindromos()
        {
            string[] palavras = Console.ReadLine().Split(' ');

            List<char> frente = new List<char>();
            List<char> costa = new List<char>();
            List<string> palindromos = new List<string>();
            foreach (string pal in palavras)
            {
              
                    for (int i = 0; i <= pal.Length - 1; i++)
                    {
                        if(pal.Length > 1)
                        {
                            frente.Add(pal[i]);

                        }
                    }
                    for (int i = pal.Length - 1; i >= 0; i--)
                    {
                       if (pal.Length > 1)
                        {
                            costa.Add(pal[i]);

                        }
                    }
                    if (frente.SequenceEqual(costa))
                    {
                       
                        palindromos.Add(pal);
                        frente.Clear();
                        costa.Clear();
                        
                  
                    }
                    else
                    {
                        frente.Clear();
                        costa.Clear();
                    }
                
               
                
            }
            
            if(palindromos.Count >= 1)
            {
                Console.WriteLine("As palavras palindromos são");
                foreach (string pal in palindromos)
                {
                    Console.Write($"  {pal}");
                }
            }
            
        }
    }
}
