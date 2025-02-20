using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Formula
    {
        public string formula;
        public string cor1;
        public int area;

        public Formula(string formula, string cor1, int area)
        {
            this.formula = formula;
            this.cor1 = cor1;
            this.area = area;
        }
    }
}
