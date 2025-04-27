using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo.Entity
{
    sealed class ProdutoUsado : Produto
    {
        public ProdutoUsado() { }

        public ProdutoUsado(DateTime dataFabricação, string nome, double valor):base(nome, valor) 
        {
            DataFabricação = dataFabricação;
        }

        public DateTime DataFabricação { get;private set; }
        public override string Etiqueta()
        {
            return $"{Nome} R${Valor.ToString("F2",CultureInfo.InvariantCulture)} (Data de fabricação : {DataFabricação} ";
        }
    }
}
