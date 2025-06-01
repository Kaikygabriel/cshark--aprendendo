using System;
using System.IO;

namespace ExercicioLinq2.Service;

public class ServicePath
{
    public List<string> Pegar(string path)
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