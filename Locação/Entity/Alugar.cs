namespace Locacao.Entity
{
    internal sealed class Alugar
    {
        public Alugar() { }
        public Alugar(string model, DateTime entrada, DateTime saida, double valorHours, double valorDay)
        {
            Model = model;
            Entrada = entrada;
            Saida = saida;
            ValorHours = valorHours;
            ValorDay = valorDay;
        }

        public string Model { get; private set; }
        public DateTime Entrada { get; private set; }
        public DateTime Saida { get; private set; }
        public double ValorHours { get; private set; }
        public double ValorDay { get; private set; }
        public TimeSpan Duration()
        {
            return Saida.Subtract(Entrada);
        }
        public double Total()
        {
            
            if (Duration.Hours < 12)
            {
                double valor = ValorHours * (Duration.Hours + 1);
                if (valor <= 100)
                {
                    double porcentagem = valor * 0.2;
                    return porcentagem + valor;
                }
                else
                {
                    double porcentagem = valor * 0.15;
                    return porcentagem + valor;
                }
            }
            else
            {
                double valor = ValorDay * (Duration.Days + 1);
                if (valor <= 100)
                {
                    double porcentagem = valor * 0.2;
                    return porcentagem + valor;
                }
                else
                {
                    double porcentagem = valor * 0.15;
                    return porcentagem + valor;
                }
            }
        }
        public override string ToString()
        {
            return $"Duration ({Entrada}) - ({Saida}) = {Duration() }, Total é R${Total()}";
        }
    } 
}