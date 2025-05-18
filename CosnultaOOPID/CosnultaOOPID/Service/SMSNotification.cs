using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosnultaOOPID.Service
{
    internal sealed class SMSNotification : INotification
    {
        public SMSNotification() { }
        public SMSNotification(string menssage)
        {
            Menssage = menssage;
        }

        public string Menssage { get; set; }
        public DateTime DataSms { get; private set; }
        public string GetNotification()
        {
            DataSms = DateTime.Now;
            return $"SMS - {Menssage}";
        }
    }
}
