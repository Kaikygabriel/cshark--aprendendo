
namespace paramsa;

internal class Program
{
    static void Main(string[] args)
    {
        int num = 10;
        Calculadora.tripicar(ref num);
        //ref indica que pode alterar o valor do parametro recebido, o parametro x vai passar a referenciar o num, ao inves de copiar
        //faz um parametro fazer referencia para a variavel original(so pode ser usado caso a variavel for iniciada )
        //a variavel passada no parametro ref deve ser iniciada 
        //a variavel passada no parametro out não precisa ser iniciada
        //ambos são um desing ruim e devem ser evitados
        Console.WriteLine(num);
        int original = 10;
        int num2;
        Calculadora.Criar(original, out num2);
        Console.WriteLine(num2);
    }
}
