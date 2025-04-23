using Herança.Entidade;

namespace Herança
{
    internal class Program
    {
        static void Main()
        {
            ContaBancaria bc = new ContaBancaria(13,"Kaiky",00);
            ContaEmpresarial ce = new ContaEmpresarial(1000,"Google",10,00);

            //UPCASTING COnverter uma subclasse(derivada) para uma superclasse(base)
            ContaBancaria teste = ce;
            ContaBancaria bc1 = new ContaEmpresarial(1000,"Gabriel",9,00);
            ContaBancaria bc2 = new ContaPoupança("Alves",13,00,0.10);

            //DOWNCASTING converter uma superclasse(base) para uma subclasse(deviada) 
            //cuidado o downcastring e muito inseguro caso as variaveis não tiver relação
            //precisa fazer um castring para poder o compilador entender 
            //ContaEmpresarial ce1 = (ContaEmpresarial)bc1;
            ContaEmpresarial  ce1 = bc1 as ContaEmpresarial;    
            ContaEmpresarial ce2 = (ContaEmpresarial)bc;
            if (bc2 is ContaBancaria)
            {
                //caso variavel bc2 for uma instancia de contabancaria , executa o codigo
            }
        }
    }
}
