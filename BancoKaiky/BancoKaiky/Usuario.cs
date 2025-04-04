using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoKaiky
{
    [System.Serializable]
    internal class Usuario
    {
        private float _carteira;
        public string Nome { get; private set; }
        public Usuario(string nome, float carteira)
        {
            Nome = nome;
            _carteira = carteira;
        }
        public float Carteira
        {
            get { return _carteira; }
            set
            {
                if (value > 0 && value != null)
                {
                    _carteira = value;
                }
            }
        }
        public void AdicionarCarteira(float VAlorAdd)
        {
            if (VAlorAdd != null && VAlorAdd > 0)
            {
                _carteira += VAlorAdd;

            }
        }
        public void Sacar(float ValorSacado)
        {
            _carteira = Math.Abs((ValorSacado - _carteira) - 5);
        }
        public override string ToString()
        {
            return $"O usuario {Nome} tem o saldo de R${_carteira}";
        }
    }
}
