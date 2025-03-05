using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Tarefa
    {
        public string userId;
        public int id;
        public string title;
        //tem que ter o mesmo nome que ta vindo na resposta
        public void exibir()
        {
            Console.WriteLine($"O userId é {userId} com id {id} eo title {title}");
        }
    }
}
