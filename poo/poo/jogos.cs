using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class jogos
    {
        public string nome;
        public string produtora;
        public float preco;
        public string categoria;
        public jogos(string nome, string produtora, float preco, string categoria)
        {
            this.nome = nome;
            this.produtora = produtora;
            this.preco = preco;
            this.categoria = categoria;
            rodar();
        }
        public void rodar()
        {
            Console.WriteLine("abrindo o jogo " + nome + " da desenvolvedora " + produtora);
        }
    }
}
