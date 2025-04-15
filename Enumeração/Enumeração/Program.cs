
using Enumeração.Entidade;
using Enumeração.Entidade.Enums;

namespace Enumeração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order(123,DateTime.Now,OrderStatus.PagamentoPendente);
            Console.WriteLine(pedido);
            string status = OrderStatus.PagamentoPendente.ToString();
            OrderStatus seiLa = Enum.Parse<OrderStatus>(status);//a string tem que estar do mesmo jeito que as instancias do OrderStatus
        }
    }
}
