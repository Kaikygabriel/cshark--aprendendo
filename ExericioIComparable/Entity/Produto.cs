using System.Globalization;

namespace ExericioIComparable.Entity
{
    public sealed class Produto : IComparable
    {
        public Produto(){}

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public int CompareTo(object? obj)
        {
            if (!(obj is Produto))
            {
                throw new Exception("ERROR não é o tipo Produto");
            }
            Produto pd = (Produto)obj;
            return Valor.CompareTo(pd.Valor);
        }

        public override string ToString()
        {
            return $"{Nome} tem o valor R${Valor.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
                