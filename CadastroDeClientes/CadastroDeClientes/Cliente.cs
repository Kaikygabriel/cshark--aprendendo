using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Valida.CPF;
using Valida.CPF.CNPJ;

namespace CadastroDeClientes
{
    internal class Cliente
    {
        public Cliente(string nome, string cpf, string endereco, string email)
        {
            bool a = ValidaCPFCNPJ.ValidaCPF(cpf);
            if (!a)
            {
                throw new ArgumentException("CPF inválido.");
                Program.Main();
            }
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Endereco {  get; set; }
        public string Email { get;set; }
        public void AlterarInformacao()
        {
            Console.WriteLine("Endereço:");
            string endereco = Console.ReadLine().Trim();
            Console.WriteLine("Email:");
            string email = Console.ReadLine().Trim();
            this.Email = email;
            this.Endereco = endereco;
        }
        public static void CadastrarCliente()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine().Trim();
            Console.WriteLine("Cpf:");
            string cpf = Console.ReadLine().Trim();
            Console.WriteLine("Endereço:");
            string endereco = Console.ReadLine().Trim();
            Console.WriteLine("Email:");
            string email = Console.ReadLine().Trim();
            Cliente add = new Cliente(nome, cpf, endereco, email);
            Program.clientes.Add(add);
        }
        public static void ListarCliente()
        {
            List<Cliente> lista = Program.clientes;
            foreach(Cliente c in lista )
            {
                Console.WriteLine($"Cliente : {c.Nome} Endereço :{c.Endereco} Cpf : {c.Cpf} Email{c.Email}");
            }
            Console.ReadLine();
        }
        public static void BuscarClientes(string Cpf)
        {
            List<Cliente> lista = Program.clientes;
            bool achou = false;
            foreach (Cliente c in lista)
            {
                if (c.Cpf.Equals(Cpf, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Cliente : {c.Nome} Endereço :{c.Endereco} Cpf : {c.Cpf} Email{c.Email}");
                    Console.ReadLine();
                    achou = true;

                }
            }
            if (!achou)
            {
                Console.WriteLine(" Não achei");
                Console.ReadLine();

            }
        }
    }
}
