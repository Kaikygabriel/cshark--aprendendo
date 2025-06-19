namespace GerenciadorDeProdutosMVC.Models
{
    public class Product
    {
        public Product() { }

        public Product(int id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price{ get; set; }

        public int Quantity{ get; set; }
    }
}
