using System;

namespace ConsoleApp4;

class Program
{
    // sempre no singular
    enum opcao{iniciar = 1,Deletar = 2,adicionar = 3,editar = 4}
     static void Main()
    {
        Console.WriteLine("Selecione umas das opções abaixo");
        Console.WriteLine("1-Iniciar \n 2-Deletar \n 3-Adicionar \n 4-editar");
        int index = int.Parse(Console.ReadLine());
        opcao opcaoSelecionada = ((opcao)index);

        switch (opcaoSelecionada)
        {
            case opcao.iniciar:
                Console.WriteLine("Voce iniciou algo");
                break;
            case opcao.Deletar:
                Console.WriteLine("Voce DEletou algo");
                break;
            case opcao.adicionar:
                Console.WriteLine("Voce adicionou algo");
                break;
            case opcao.editar:
                Console.WriteLine("Voce editou algo");
                break;
            default:
                Console.WriteLine("[ERROR] opcão não encontrada");
                break;
        }

        Console.ReadLine();
    }
}
