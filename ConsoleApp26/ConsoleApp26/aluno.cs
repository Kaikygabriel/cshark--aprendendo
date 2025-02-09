using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class aluno : Usuario
    {
        
        public string periodo; 
        public int ra;
        //quando cria um construtor na classe pai, e obrigado a chamar ele na classe filho
        //: base => ele chama o contrutor da classe pai, e vai passar o valores do contrutor da classe pai pede
        public aluno(string periodo, int ra,string nome,string email): base(nome,email) 
        {
            this.periodo = periodo;
            this.ra = ra;
        }
    }
}
