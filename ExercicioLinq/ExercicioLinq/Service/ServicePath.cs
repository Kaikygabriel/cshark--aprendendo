using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioLinq.Service
{
    internal class ServicePath: IPath
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
}

        