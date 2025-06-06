using JogoForcaOOP.Service.Contratos;

namespace JogoForcaOOP.Service;

public class ServiceRepositoryTxt : IServiceRepositoryPalavras
{
    public List<string> CapturarPalavras(string path)
    {
        List<string> ListWord = new List<string>();
        using (StreamReader rd = new StreamReader(path))
        {
            while (!rd.EndOfStream)
            {
                ListWord.Add(rd.ReadLine());
            }
        }

        return ListWord;
    }
}