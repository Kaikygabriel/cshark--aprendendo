using JogoForcaOOP.Service.Contratos;

namespace JogoForcaOOP.Service;

public class ServiceRandomWord
{
    public ServiceRandomWord(){}

    public ServiceRandomWord(IServiceRepositoryPalavras palavras,string path)
    {
        _palavras = palavras;
        _path = path;
    }
    
    private IServiceRepositoryPalavras _palavras;
    private string _path;
    
    public string RandomWord()
    {
        List<string> ListWord = _palavras.CapturarPalavras(_path);
        if (ListWord.Count <= 0)
            throw new Exception("Error,Not word found in repository");
        Random random = new Random();
        
        return ListWord[random.Next(0, ListWord.Count - 1)];
    }
}