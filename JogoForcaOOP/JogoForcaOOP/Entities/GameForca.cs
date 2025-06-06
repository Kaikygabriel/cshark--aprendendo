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
        List<char> CaracterErrados = new List<char>();
        string randomWord = _serviceRandomWord.RandomWord();
        int chances = randomWord.Length + (randomWord.Length / 2);
        List<char> list = _serviceGameList.ListRandomChar(randomWord);
       
        while (!_serviceWinner.Winner(list) && chances > 0 )
        {
            Console.WriteLine("Suas chances são "+chances);
            CaracterErrados.ForEach(x=>Console.Write($" {x} "));
            Console.WriteLine("");
            
            foreach (var l in list)
            {
                Console.Write($" {l}");
            }
            
            Console.WriteLine(" ");
            char caracterJogador = JogadorFunction.Letra();
            CaracterErrados.Add(caracterJogador);
            list = _serviceGameList.ListcharGame(list, randomWord, caracterJogador);
            Console.Clear();
            chances -= 1;
        }
        
        if(_serviceWinner.Winner(list))
             Console.WriteLine("Voce Ganhou !!!");
        else
            Console.WriteLine("voce perdeu");
        
        Console.WriteLine(randomWord);
        Console.ReadLine();
    }
}