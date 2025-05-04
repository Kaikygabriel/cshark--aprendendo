using System.Globalization;
using System;
using System.Text;
using System.Net;
using ExercicioExce__o.Entity.Exceptions.Entity.Exceptions;
using Newtonsoft.Json;

namespace ExercicioExce__o.Entity.Entity
{
    sealed internal class Conta
    {
        public Conta() { }

        public Conta(int numero, string nome, double saldo, double saldoLimite)
        {
            if (saldo < 0)
            {
                throw new DominioException("Saldo tem que ser acima de zero");
            }
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            SaldoLimite = saldoLimite;
        }

        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public double SaldoLimite { get; private set; }
        
        public void Sacar(double valor)
        {
            if (valor > SaldoLimite)
            {
                throw new DominioException("O valor é maior que limite");
            }
            if (valor > Saldo)
            {
                throw new DominioException("O valor é maior que o  saldo atual");
            }
            Saldo -= valor;
        }
        public void AdicionarSaldo(double valor)
        {
            if (valor < 0)
            {
                throw new DominioException("Valor de deposito abaixo de zero");
            }
            Saldo += valor;
        }
        public void Caixinha(double entrada)
        {
            if (entrada < 0)
            {
                throw new DominioException("Selic esta menor que zero ");
            }
           
            double cdi = Math.Abs((TaxaSelic() / 100 )- 0.10);
            
            double valorFinal = entrada * cdi;
            System.Console.WriteLine("Valor final seria de R$"+valorFinal.ToString("F2",CultureInfo.CurrentCulture));
        }
        public double TaxaSelic()
        {
            
                Selic selic = new Selic();
                var requisicao = WebRequest.Create("https://api.bcb.gov.br/dados/serie/bcdata.sgs.432/dados/ultimos/1?formato=json");
                requisicao.Method = "Get";
                using (var resposta = requisicao.GetResponse())
                {
                    var stream = resposta.GetResponseStream();
                    StreamReader fluxo = new StreamReader(stream);
                    var dados = fluxo.ReadToEnd();

                    List<Selic> selicList = JsonConvert.DeserializeObject<List<Selic>>(dados);
                    
                    selic = selicList[0];

                    fluxo.Close();
                    resposta.Close();
                }
                return selic.valor;
            
           
        }
    }
}