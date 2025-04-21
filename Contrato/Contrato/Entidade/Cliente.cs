using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Contrato.Entidade.Enum;

namespace Contrato.Entidade
{
    internal class Cliente
    {
        public Departamento Departamento = new Departamento();
        public string Nome;
        public float ContratoBase;
        public Nivel Nivel;
        public Cliente(string nome, float contratoBase, Nivel nivel,string nomeDepartamento)
        {
            Departamento.nome = nomeDepartamento;
            Nivel = nivel;
            Nome = nome;
            ContratoBase = contratoBase;
        }

        public Cliente()
        {
        }

        public List<Contrato> contratos = new List<Contrato>();
        public void AdicionarContratos()
        {
            Console.Write("Date (DD/MM/yyyy) :");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("valor por hora :");
            float value = float.Parse(Console.ReadLine());
            Console.Write("Total de horas :");
            int horas = int.Parse(Console.ReadLine());
            contratos.Add(new Contrato(data,value,horas));
        }
        public void CalcularTotal(DateTime mes)
        {
            float soma = ContratoBase;
            foreach(Contrato c in contratos)
            {
                if(c.Momento.Month == mes.Month && c.Momento.Year == mes.Year)
                {
                    soma += c.ValorTotal();
                }
            }
            Console.WriteLine($"Nome : {this.Nome} \nDepartamento {Departamento.nome}\nValor ganho em {mes.Month}/{mes.Year} é R${soma}");
        }
    }
}
