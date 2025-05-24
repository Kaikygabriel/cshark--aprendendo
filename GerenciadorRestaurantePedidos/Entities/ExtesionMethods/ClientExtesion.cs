using GerenciadorRestaurantePedidos.Entities;

namespace System
{
    public static class ClienteExtesion
    {
        public static void Mostrar(this Cliente cliente)
        {
            System.Console.WriteLine(cliente);
        }    
    }
    
}