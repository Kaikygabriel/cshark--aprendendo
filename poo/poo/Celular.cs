using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class Celular
    {
        public string nome;
        public float preco;
        public float memoriaRam;
        public string processador;
        public float tela;

        public Celular(string nome,float preco,float memoriaRam,string processador,float tela)
        {
            this.nome = nome;
            this.preco = preco; 
            this.memoriaRam = memoriaRam;
            this.processador = processador;
            this.tela = tela;
            mostrar();
        }
        public void mostrar()
        {
            Console.WriteLine($"O celular {this.nome}, tem o preço R${this.preco}, com o processador {processador}, ea memoria Ram de {memoriaRam}Gb, com uma tela de {tela}CM");
        }
    }
}
