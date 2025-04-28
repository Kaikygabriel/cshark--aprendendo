using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPessoa.Entity
{
    internal sealed class PessoaFisica : Pessoa
    {
        public PessoaFisica() { }
        public PessoaFisica(string nome, double renda,double saude) : base(nome, renda)
        {
            Saude = saude;
        }
        public  double Saude { get; set; }
        public override double ImpostoTotal()
        {
            if(Renda >= 50000)
            {
                return (Renda * 0.25) - (Saude * 0.5);
            }
            else
            {
                return (Renda * 0.15) - (Saude * 0.5);
            }
        }
    }
}
