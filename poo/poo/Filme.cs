using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class Filme
    {
        public string nome;
        public List<string> ator = new List<string>();
        public float duracao;
        public string categoria;

        public Filme(string nome,  float duracao, string categoria)
        {
            this.nome = nome;
            this.duracao = duracao;
            this.categoria = categoria;
            abrir();
        }   
        public  void abrir()
        {
            Console.WriteLine($"abrir filme : {nome}");
        }
        public  void fechar()
        {
            Console.WriteLine("fechar filme "+ nome + duracao );
        }
    }
}
