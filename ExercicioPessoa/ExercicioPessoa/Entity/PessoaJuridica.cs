using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPessoa.Entity
{
    internal sealed class PessoaJuridica : Pessoa
    {
        public PessoaJuridica() { }
        public PessoaJuridica(int funcionarios, string nome, double renda):base(nome,renda)
        {
            Funcionarios = funcionarios;
        }
        public int Funcionarios { get; set; }
        public override double ImpostoTotal()
        {
            if(Funcionarios > 10)
            {
                return Renda * 0.14;
            }
            else
            {
                return Renda * 0.16;
            }
        }
    }
}
