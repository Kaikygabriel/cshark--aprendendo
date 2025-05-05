namespace Projeto
{
    public class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 3,4, 1, 2 };
            Ordernar(list);
        }
        static void Ordernar(List<int> lista)
        {
            int[]lista2 = new int[lista.Count];
         
            List<bool> teste = new List<bool>();
            int valorAtual= 0 ;
            while (valorAtual != lista.Count )
            {
                for (int i = 0; i <= lista.Count - 1; i++)
                {
                    if (lista[valorAtual] > lista[i] && lista[valorAtual] != lista[i])
                    {
                        teste.Add(true);
                    }
                    else
                    {
                        teste.Add(false);
                    }
                }

                int posicao = 0;
                foreach (bool i in teste)
                {
                    if (i == true)
                    {
                        posicao += 1;
             
                    }
                }
                teste.Clear();
              
                lista2[posicao] = lista[valorAtual];
                
                valorAtual += 1;
            }
            
            foreach (int num in lista2)
            {
                System.Console.Write(num);
            }
        }
    }
}