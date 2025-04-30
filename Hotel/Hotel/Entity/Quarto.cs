using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entity.Enums;

namespace Hotel.Entity
{
    internal abstract class Quarto
    {
        public Quarto() { }

        protected Quarto( double valor, int id)
        {
            StatusQuarto = Status.Livre;
            Valor = valor;
            Id = id;
        }

        public Status StatusQuarto{ get; set; }
        public double Valor { get; set; }
        public int Id{ get; set; }
        public abstract double GetValor();
        public abstract string Descricao();
        public void Liberar()
        {
            StatusQuarto = Status.Livre;
        }
        public void Ocupar()
        {
            StatusQuarto = Status.Reservado;
        }
    }
}
