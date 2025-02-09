using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lendoescrevendo
{
    [System.Serializable]
    struct produtos 
    {
    public string nome;
    public produtos(string nome) 
        {
        this.nome = nome;
        }
    }
 internal class Program
    {
        static void Main()
        {
            produtos roupa = new produtos("roupa-PUMA");
            List<int> valores = new List<int>() {1,2,3,4,5};
            FileStream bin = new FileStream("teste.txt",FileMode.OpenOrCreate);
            BinaryFormatter converter = new BinaryFormatter();
            //converter.Serialize(bin, valores);
            //converter.Serialize(bin, roupa);
            //processo de escrever
            //

            List<int> listaarquivo = (List<int>)converter.Deserialize(bin);
            //se não for do mesm o tipo do que colocou vai dar error
            produtos roupaestoque = (produtos)converter.Deserialize(bin);
            //processo de leitura
            //tem que saber oque tem dentro
            //saber a ordem que elas foram escritass
            Console.WriteLine(valores[0]);
            Console.WriteLine(roupaestoque.nome);
            bin.Close();
        }
    }
}
