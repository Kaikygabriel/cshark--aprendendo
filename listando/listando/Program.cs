namespace listando
{
    internal class Program
    {
        static void Main()
        {
            List<string> jogos = new List<string>(){ "Minecraft", "roblox","gta","gta" };
            foreach (string jogo in jogos)
            {
                Console.WriteLine(jogo);
            }

            Console.WriteLine(jogos.Count);
            //retorna quantos elementos tem na lista
            jogos.RemoveAt(1);
            //remove o elemento por indice
            jogos.RemoveAll(jogos => jogos == "gta");
            //se jogos for igual a jogos gta remove ele da lista
            // para cada elemento da lista, o csharp vai fazer o teste com esse predicado(frases ou palvra) e se for verdadeiro ele remove
            string busca = jogos.Find(jogos => jogos != "Minecraft");
            //ele pesquisa um jogo igual a minecraft 
            //posso colocar qualquer condição que retorne verdadeiro ou falso
            Console.WriteLine(busca);
            foreach (string jogo in jogos) 
            {
                Console.WriteLine(jogo);
            }
        }
    }
}
