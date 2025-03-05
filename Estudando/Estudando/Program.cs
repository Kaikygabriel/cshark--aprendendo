using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Estudando
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Gerenciador de Cep\n Informe o seu Cep");
            var cep = Console.ReadLine();
            
                var requisicao = WebRequest.Create($"https://viacep.com.br/ws/{cep}/json/");
                requisicao.Method = "Get";
              
                using (var resposta = requisicao.GetResponse())
                {
                    var stream  = resposta.GetResponseStream();
                    StreamReader fluxo = new StreamReader(stream);
                    object dados = fluxo.ReadToEnd();
                    Cep resu = JsonConvert.DeserializeObject<Cep>(dados.ToString());
                    resu.exibir();
                    Console.ReadLine();

                    resposta.Close();
                    fluxo.Close();
                }
            
        }
    }
}
