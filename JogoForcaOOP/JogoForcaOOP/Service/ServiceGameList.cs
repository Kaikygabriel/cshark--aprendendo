namespace JogoForcaOOP.Service;

public partial class ServiceGameList
{
    public List<char> ListcharGame(List<char>ListRandomCaracter,string word,char letra)
    {
        for(int i = 0; i <= word.Length -1; i++)
        {
            if (word[i].Equals(letra)) 
                ListRandomCaracter[i] = letra;
        }

        return ListRandomCaracter;
    }
}