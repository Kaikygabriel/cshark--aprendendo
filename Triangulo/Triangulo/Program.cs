namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(3.00,4.00,5.00);
            t1.exibir();
            Triangulo t2 = new Triangulo(6.00, 7.00, 5.00);
            t2.exibir();
            Triangulo.VerMaior(t1 , t2);
        }
    }
}
