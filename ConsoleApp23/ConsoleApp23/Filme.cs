using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Filme
    {
        public string nome;
        public string studio;
        private List<string> atores = new List<string>();
        // private == somente essa class pode acessar esse metodo ou instancia
        //facilita caso precise mudar e seu programa estiver muito grande 
        //vc tem a garantia que so usa ele naquela class 
        public Filme(string nome, string studio)
        {
            this.nome = nome;
            this.studio = studio;
            //não e obrigado a definir todos os valores dos campos, dentro do construtor
            // não e limitado apenas a valores, pode passar qualquer logica
           
        }
        //encapsulamento você impedi que o externo acesse as informações do seu objeto diretamente, e colocar um intermediador(acessar atraves de função)
        public void addator(string nome)
        {
            if (nome != null && nome.Length >= 1)
            {
                atores.Add(nome);
            } 
        }
        public void exibir()
        {
            foreach (string s in atores)
            {
                Console.WriteLine(s);
            }
        }
    }
}

