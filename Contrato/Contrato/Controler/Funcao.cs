using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Contrato.Entidade;
using Contrato.Entidade.Enum;

namespace Contrato.Controler
{
    internal class Funcao
    {
        static Cliente clienteBase;
        public static void AdicionarUsuario()
        {
            try
            {
                Console.WriteLine("Nome do departamento :");
                string nomeDepartamento = Console.ReadLine();
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.Write($"Level ({Nivel.Junior} /{Nivel.Medio} /{Nivel.Senior} )");
                Nivel nivel = Enum.Parse<Nivel>(Console.ReadLine());
                Console.WriteLine("Salario base");
                float salarioBase = float.Parse(Console.ReadLine());
                clienteBase = new Cliente(nome, salarioBase, nivel, nomeDepartamento);
            }
            catch(Exception e)
            {
                Console.Clear();
                AdicionarUsuario();
            }

        }
        public static void AdicionarContrato()
        {
            Console.WriteLine("Quantos contratos quer adicionar ");
            int contratosNum = int.Parse(Console.ReadLine());
            for(int i = 1; i <= contratosNum; i++)
            {
                Console.WriteLine($"Contrato #{i}");
                clienteBase.AdicionarContratos();
            }
        }
        public static void Total()
        {
            Console.WriteLine("Digite o mes que quer saber o ganho total MM-yyyy");
            DateTime data = DateTime.Parse($"01/{Console.ReadLine()}");

            clienteBase.CalcularTotal(data);
        }
    }
}
