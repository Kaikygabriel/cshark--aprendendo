using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosnultaOOPID.Service
{
    internal sealed class EmailNotification : INotification
    {
        public EmailNotification() { }
        public EmailNotification(string menssage)
        {
            Menssage = menssage;
        }
        public string Menssage { get; set; }
        public DateTime DataEmail { get; private set; }
        public string GetNotification()
        {
            DataEmail = DateTime.Now;
            return $"Email - {DataEmail.ToString("dd/MM/yyyy")}- {Menssage}";
        }
    }
}
