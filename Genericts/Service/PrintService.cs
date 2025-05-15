namespace Genericts.Service
{
    public class PrintService
    {
        public void Adicionar(List<int> valores, int valor)
        {
            valores.Add(valor);
        }
        public int PrimerioNumero(List<int> valores)
        {
            return valores[0];
        }
        public void GetList(List<int> valores)
        {
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }
        }
    }
}