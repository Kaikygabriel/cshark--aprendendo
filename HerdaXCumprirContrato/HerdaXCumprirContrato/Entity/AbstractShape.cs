using System;
using System.Collections.Generic;
using HerdaXCumprirContrato.Entity.Enum;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerdaXCumprirContrato.Entity
{
    internal abstract class AbstractShape : shape
    {
        public Color Color{ get; private protected set; }
        public abstract double Area();   
    }
}
