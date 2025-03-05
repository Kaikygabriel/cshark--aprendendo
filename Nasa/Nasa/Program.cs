using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ver a data ");
            var requisicao = WebRequest.Create("https://api.nasa.gov/planetary/apod?api_key=VanogKAaFBxErZvrpUvPBh5FXtFQMVcrYGyUaNld");
            requisicao.Method = "GET";
            using(var resposta = requisicao.GetResponse())
            { 
                var stream = resposta.GetResponseStream();
                StreamReader fluxo = new StreamReader(stream);
                object dados = fluxo.ReadToEnd();
                Dia dias = JsonConvert.DeserializeObject<Dia>(dados.ToString());
                dias.exibir();
                fluxo.Close();
                resposta.Close();
            }
        }
    }
}
