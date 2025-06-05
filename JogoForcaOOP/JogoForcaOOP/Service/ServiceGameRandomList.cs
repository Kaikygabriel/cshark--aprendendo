namespace JogoForcaOOP.Service;

public partial class ServiceGameList
{
    public List<Char> ListRandomChar(string word)
    {
        List<char> listChar = word.ToListChar();
        List<char> ListCharCaracter = new List<char>();
        for (int i = 0; i <= listChar.Count -1; i++)
            ListCharCaracter.Add('_');
        
        return ListCharCaracter;
    }
}