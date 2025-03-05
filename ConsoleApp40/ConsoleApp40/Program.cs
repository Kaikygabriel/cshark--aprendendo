using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp40
{  
    enum OP {mult= 1,unico}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ver Tarefas \n 1 - Todas as Tarefas \n 2 - Tarefa especifica");
            OP sele = (OP)int.Parse(Console.ReadLine());
            if (sele != null)
            {
                switch (sele)
                {
                    case OP.mult:
                        MultiplosDados();
                        break;
                    case OP.unico:
                        dadoUnico();
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
        }
        static void dadoUnico()
        {
            Console.WriteLine("Escolha o numero da tarefa");
            string escolha = Console.ReadLine();
            var Requisicao = WebRequest.Create($"https://jsonplaceholder.typicode.com/posts/{escolha}");
            //pode ser qualquer url da web 
            //diz que quer fazer uma requisição pra a url que ta sendo passada, é como fosse um objeto
            Requisicao.Method = "GET";//metodo para fazer a requisição (get )

            //using para facilitar a requisição
            //getresponse que vai mandar  a requisição
            using (var resposta = Requisicao.GetResponse())
            {
                var stream = resposta.GetResponseStream();
                StreamReader fluxo = new StreamReader(stream);
                object dados = fluxo.ReadToEnd();

                //se fosse multiplo dados seria list<tarefa>
                //dados.tostring ele vai pegar e converter para um objeto
                
                Tarefa tarefas = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());
                tarefas.exibir();

                fluxo.Close(); //fechando a stream
                resposta.Close();//fechando a requisição
            }
            Console.ReadLine();
        }
        static void MultiplosDados()
        {
            var Requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/posts/");
            //pode ser qualquer url da web 
            //diz que quer fazer uma requisição pra a url que ta sendo passada, é como fosse um objeto
            Requisicao.Method = "GET";//metodo para fazer a requisição (get )

            //using para facilitar a requisição
            //getresponse que vai mandar  a requisição
            using (var resposta = Requisicao.GetResponse())
            {
                var stream = resposta.GetResponseStream();
                StreamReader fluxo = new StreamReader(stream);
                object dados = fluxo.ReadToEnd();

                //se fosse multiplo dados seria list<tarefa>
                //dados.tostring ele vai pegar e converter para um objeto
                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());
                foreach (Tarefa tf in tarefas)
                {
                    tf.exibir();
                }
                fluxo.Close(); //fechando a stream
                resposta.Close();//fechando a requisição
            }
            Console.ReadLine();

        }
    }
}
