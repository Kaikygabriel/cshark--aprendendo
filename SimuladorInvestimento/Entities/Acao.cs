using System;

namespace SimuladorInvestimento.Entities
{
    public class Acao
    {
        public Acao() { }

        public Acao(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Codigo { get; private set; } = Guid.NewGuid().ToString().ToUpper()[..8];
        public string Nome { get;  set; }
        public double Valor { get;  set; }

        public override string ToString()
        {
            return $"{Nome} -- R${Valor.ToString("F2")}";
        }
    }
}