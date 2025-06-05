using JogoForcaOOP.Entities;
using JogoForcaOOP.Service;

public class Program
{
    static void Main()
    {
        ServiceRandomWord serviceRandomWord =
            new ServiceRandomWord(new ServiceRepositoryTxt(), @"C:\Users\kaiky\Downloads\Palavras.txt");
        ServiceWinner serviceWinner = new ServiceWinner();
        ServiceGameList serviceGameList = new ServiceGameList();
        GameForca game = new GameForca(serviceRandomWord, serviceWinner, serviceGameList);
        game.GameStart();
    }
}