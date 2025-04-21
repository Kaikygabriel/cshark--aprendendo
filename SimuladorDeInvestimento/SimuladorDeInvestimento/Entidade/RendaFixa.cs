using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SimuladorDeInvestimento.Entidade
{
    internal class RendaFixa
    {
        public RendaFixa() { }
        public RendaFixa(float valor)
        {
            Valor = valor;
        }
        public float Valor { get; set; }
        private  float TaxaSelic()
        {
            DateTime agora = DateTime.Now;
            string a = agora.ToString("dd/MM/yyyy");

            List<Selic> selicTaxa = new List<Selic>();
            var requisicao = WebRequest.Create($"https://api.bcb.gov.br/dados/serie/bcdata.sgs.432/dados?formato=json&dataInicial={a}&dataFinal={a}");
            requisicao.Method = "Get";
            using (var resposta = requisicao.GetResponse())
            {
                var stream = resposta.GetResponseStream();
                StreamReader fluxo = new StreamReader(stream);
                object dados = fluxo.ReadToEnd();
                selicTaxa = JsonConvert.DeserializeObject<List<Selic>>(dados.ToString());
            }
            Selic sc = new Selic();
            foreach (var b in selicTaxa)
            {
                sc = b;
            }
            return sc.valor;
        }
        public void CalcularAno(int anos)
        {
            float selic = TaxaSelic() / 100;
            float ValorFInal = Valor;
            for (int i = 1; i <= anos; i++)
            {
                ValorFInal = ValorFInal+(ValorFInal * selic);
            }
            Console.WriteLine("Valor final seria R$"+ValorFInal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
