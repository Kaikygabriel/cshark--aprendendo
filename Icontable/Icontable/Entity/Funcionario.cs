using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icontable.Entity
{
    internal class Funcionario : IComparable
    {
        public Funcionario() { }
        public string Nome { get; private set; }
        public double Salario { get;private set; }
        public Funcionario(string employe)
        {
            string[] vect = employe.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1]);
        }
        public override string ToString()
        {
            return $"{Nome} , R${Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Funcionario))
            {
                throw new Exception("ERROR não e do tipo funcionario");
            }
            Funcionario funcionario = (Funcionario)obj;
            return Nome.CompareTo(funcionario.Nome);
        }
    }
}
