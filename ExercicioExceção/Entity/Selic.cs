namespace ExercicioExce__o.Entity
{
    class Selic
    {
        public Selic(){}
        public Selic(double valor, string data)
        {
            this.valor = valor;
            this.data = data;
        }

        public double valor { get; private set; } 
        public string data{ get; private set; }
    }
}