using StoreWithPagamentOOP.Entites;
using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit;

namespace StoreWithPagamentOOP.Service;

public class EmailServicePagament : IEmailService
{
    public void EnviarEmail(Client client)
    {
        var teste = "ola";
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse("kaikygabrielalves708@gmail.com"));
        email.To.Add(MailboxAddress.Parse(client.Email));
        email.Subject = "Pagament product";

        email.Body = new TextPart("plain")
        {
            Text =$"Client {client} adquiriu um produto"
        };

        using var smtp = new SmtpClient();
        smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

        // Use sua senha de aplicativo, NÃO a senha normal!
        smtp.Authenticate("kaikygabrielalves708@gmail.com", "vdog kflv aamy cbvo");

        smtp.Send(email);
        smtp.Disconnect(true);

    }
}