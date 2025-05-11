namespace ImportacaoDePeca.Entity
{
    internal sealed class ImportPart : Part
    {
        public ImportPart() { }

        public ImportPart(double taxa, string nome, double valor) : base(nome, valor)
        {
            Taxa = taxa;
        }

        public double Taxa { get; private set; }
        public override double GetTotal()
        {
            return Valor + (Valor * Taxa);
        }
        public override string GetPart()
        {
            return $"O produto {Nome} ";
        }
    }
}