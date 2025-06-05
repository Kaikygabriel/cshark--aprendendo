using JogoForcaOOP.Controler;
using JogoForcaOOP.Service;
using JogoForcaOOP.Service.Contratos;

namespace JogoForcaOOP.Entities;

public class GameForca
{
    public GameForca(){}

    public GameForca(ServiceRandomWord serviceRandomWord, ServiceWinner serviceWinner, ServiceGameList serviceGameList)
    {
        _serviceRandomWord = serviceRandomWord;
        _serviceWinner = serviceWinner;
        _serviceGameList = serviceGameList;
    }

    
    private ServiceRandomWord _serviceRandomWord;
    private ServiceWinner _serviceWinner;
    private ServiceGameList _serviceGameList;

    public void GameStart()
    {
        string randomWord = _serviceRandomWord.RandomWord();
        int chances = randomWord.Length + (randomWord.Length / 2);
       
        List<char> list = _serviceGameList.ListRandomChar(randomWord);
        while (!_serviceWinner.Winner(list) && chances > 0 )
        {
            Console.WriteLine("Suas chances são "+chances);
            Console.WriteLine(" ");
            
            foreach (var l in list)
            {
                Console.Write($" {l}");
            }
            
            Console.WriteLine(" ");
            list = _serviceGameList.ListcharGame(list, randomWord, JogadorFunction.Letra());
            Console.Clear();
            chances = chances - 1;

        }
        if(_serviceWinner.Winner(list))
             Console.WriteLine("Voce Ganhou !!!");
        else
            Console.WriteLine("voce perdeu");
        Console.WriteLine(randomWord);
        Console.ReadLine();
    }
}