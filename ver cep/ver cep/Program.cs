using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ver_cep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva o cep");
            string cep = Console.ReadLine();
            var requisicao = WebRequest.Create($"https://viacep.com.br/ws/{cep}/json/");
            requisicao.Method = "GET";
            var resposta = requisicao.GetResponse();
            using (resposta)
            {
                var stream = resposta.GetResponseStream();
                StreamReader fluxo = new StreamReader(stream);
                object dados = fluxo.ReadToEnd();
                Console.WriteLine(dados.ToString());

                resposta.Close();
                fluxo.Close();
            }
            Console.ReadLine();
        }
    }
}
