namespace ExercicioLinq3.Service;

public class ServicePathEmploy : IServicePath
{
    public List<string> Fazer(string path)
    {
        List<string> list = new List<string>();
        using (StreamReader rd = new StreamReader(path))
        {
            while (!rd.EndOfStream)
            {
                list.Add(rd.ReadLine());
            }
        }

        return list;
    }
}