using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Service
{
    internal class SMSNotification : INotification
    {
        public void Enviar(string Menssage)
        {
            Console.WriteLine($"[ SMS ]{DateTime.Now} - {Menssage}"); ;
        }
    }
}
