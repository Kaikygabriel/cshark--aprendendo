using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Service
{
    internal sealed class EmailNotification : INotification
    {
        public void Enviar(string Menssage)
        {
            Console.WriteLine($"[ Email ] Menssage - { Menssage}");
        }
    }
}
