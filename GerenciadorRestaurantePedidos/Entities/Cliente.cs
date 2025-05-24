namespace GerenciadorRestaurantePedidos.Entities
{
    public sealed class Cliente
    {
        public Cliente() { }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        public override string ToString()
        {
            return $"{Nome} -- {Id}";
        }
    }
}