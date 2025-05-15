using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Service;

namespace Notification.Entity
{
    internal sealed class UserNotifier
    {
        public UserNotifier() { }

        public UserNotifier(INotification notification)
        {
            _notification = notification;
            Id = Guid.NewGuid().ToString().Substring(0,8);
        }
        public string Id { get; private set; }
        private INotification _notification;

        public void Notificar(string msg)
        {
            _notification.Enviar(msg);
        }
    }
}
