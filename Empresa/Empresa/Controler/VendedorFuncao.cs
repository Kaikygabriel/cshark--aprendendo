using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Entidade;
namespace Empresa.Controler
{
    internal class VendedorFuncao
    {
        static List<Vendedor> vendedores = new List<Vendedor>();
        public static void AdicionarVendedor()
        {
            try
            {
                Console.WriteLine("Digite o nome do vendedor");
                string nome = Console.ReadLine().Trim();
                Console.WriteLine("Digite o salario");
                float salario = float.Parse(Console.ReadLine());
                vendedores.Add(new Vendedor(nome, salario));
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR tente novamente");
                Console.ReadLine();
                Console.Clear();
                AdicionarVendedor();
            }
        }
        public static void PagarVendedor()
        {
            try
            {
                if (vendedores.Count > 0)
                {
                    foreach (Vendedor v in vendedores)
                    {
                        Console.WriteLine($"O vendedor {v.Nome} o salario esta {(v.Pago ? "pago" : "Não pago")}");
                    }
                    Console.WriteLine("Escolha o nome do funcionario que deseja pagar");
                    string nome = Console.ReadLine().Trim();
                    foreach (Vendedor v in vendedores)
                    {
                        if (v.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                        {
                            if (!(v.Pago))
                            {
                                Console.WriteLine("Informe o salario do vendedor");
                                float salario = float.Parse(Console.ReadLine());
                                Console.WriteLine("Informe a quantidade de vendas");
                                int quantidade = int.Parse(Console.ReadLine());
                                v.PagarVendedor(salario, quantidade);
                                Console.WriteLine("O funcionaro foi pago");
                            }
                            else
                            {
                                Console.WriteLine("Vendedor ja foi pago");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Não tem nenhum vendedor");
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR ");
                Console.ReadLine();
            }
        }
    }
}

