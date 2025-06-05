namespace JogoForcaOOP.Controler;

public static class JogadorFunction
{
    public static  char Letra()
    {
        Console.WriteLine("Escreava uma letra");
        char letra = char.Parse(Console.ReadLine());
        return letra;
    }   
}