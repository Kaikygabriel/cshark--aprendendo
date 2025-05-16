using System;

namespace ExercicioGeneric.Service
{
    internal class Repositorio<k>
    {
        private List<k> _list = new List<k>();
        public void Adicionar(k valor)
        {
            _list.Add(valor);
        }
        public void Remover(k valor)
        {
            if (_list.Count <= 0)
            {
                throw new Exception("ERROR , lista não tem elementos. ");
            }
            for (int i = 0; i <= _list.Count - 1; i++)
            {
                if (_list[i].Equals(valor)) _list.Remove(_list[i]);
            }
        }
        public void GetLista()
        {
            foreach(var k in _list)
            {
                Console.WriteLine(k);
            }
        }
    }
}