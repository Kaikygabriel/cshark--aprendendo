





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssentosCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] cinema = { true, false, true, true, false };
            bool[]cinema2 = { true, true, false, false ,true};
            Retorna(cinema, cinema2);
        }
        static void Retorna(bool[] cinema, bool[] cinema2)
        {
            List<string> assentos = new List<string>();
            foreach (bool a in cinema)
            {
                foreach(bool b in cinema2)
                {
                    if(a == true && b == true)
                    {
                        assentos.Add("Assento não reservado, pode sentar");
                        break;
                    }
                    if((a == true || a == false) && b == false)
                    {
                        assentos.Add("Não quer sentar");

                        break;
                    }
                    if(b == true && a == false)
                    {
                        assentos.Add("Assento  reservado,não pode sentar");
                        break;
                    }
                }
            }
            foreach(string a in assentos)
            {
                Console.WriteLine(a);
            }
        }
        
    }
}
