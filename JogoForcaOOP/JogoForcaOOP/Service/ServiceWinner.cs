namespace JogoForcaOOP.Service;

public class ServiceWinner
{
    public bool Winner(List<char> listChar)
    {
        foreach (var c in listChar)
        {
            if (c == '_')
                return false;
        }

        return true;
    }
}