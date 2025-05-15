using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Service
{
    internal interface INotification
    {
        void Enviar(string Menssage);
    }
}
