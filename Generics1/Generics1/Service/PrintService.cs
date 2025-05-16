using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1.Service
{
    internal sealed class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;
        public void AddValue(T value)
        {
            if(_count > 10)
            {
                throw new Exception("error");
            }
            _values[_count] = value;
            _count ++;
        }
        public T First()
        {
            if (_count == 10)
            {
                throw new Exception("error");
            }
            return _values[0];
        }
        public void Print()
        {
           for(int i =0;i <= _count - 1; i++)
            {
                Console.WriteLine(_values[i]);
            }
        }
    }
}
