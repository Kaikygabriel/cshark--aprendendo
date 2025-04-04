using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotaçãoDoDolar
{
    internal class Calcular
    {
        public static void Receber()
        {
            Console.WriteLine("Qual a cotação do dolar ? ");
            float cotacao = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual valor que deseja comprar em dolar");
            float Compra = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float real = ConversorDeMoeadas(Compra, cotacao);
            Console.WriteLine("Valor a ser pago em reais é R$" +real.ToString("F2",CultureInfo.InvariantCulture));
        }
        static float ConversorDeMoeadas(float compra, float cotacao)
        {
            float Final = (compra * cotacao)* 0.06f;
            float ValorFinal = compra * cotacao + Final;
            return ValorFinal;
        }
    }
}


