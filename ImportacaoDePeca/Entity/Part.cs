using System.Globalization;

namespace  ImportacaoDePeca.Entity
{
    internal class Part
    {
        public Part() { }

        public Part(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; private protected set; }
        public double Valor { get; private protected set; }
        public virtual double GetTotal()
        {
            return Valor;
        }
        public virtual string GetPart()
        {
            return $"A peça {Nome} tem o valor de R${Valor.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}