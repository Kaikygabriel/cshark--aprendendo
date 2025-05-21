using System;
using System.IO;
using ExercicioHash.Entitie;

namespace ExercicioHash.Service
{
    internal sealed class ServicePath
    {
        public List<string> Pegar(string caminho)
        {
            List<string> list = new List<string>();
            using (StreamReader rd = new StreamReader(caminho))
            {
                while (!(rd.EndOfStream))
                {
                    list.Add(rd.ReadLine());
                }
            }
            return list;
        }
    }
}
