using System;
using System.Collections.Generic;

namespace ExercicioLinq.Service
{
    internal interface IPath
    {
        public List<string> Pegar(string path);
    }
}
