using Notification.Entity;
using Notification.Service;

namespace Notification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserNotifier user = new UserNotifier(new EmailNotification());
            UserNotifier user2 = new UserNotifier(new SMSNotification());
            Console.WriteLine(user.Id);
            Console.WriteLine(user2.Id);

            user.Notificar("Ola mundo com email");
            user2.Notificar("OLa novamente com sms");
        }
    }
}
