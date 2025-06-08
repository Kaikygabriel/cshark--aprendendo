using StoreWithPagamentOOP.Entites;
using StoreWithPagamentOOP.Entites.Enum;
using StoreWithPagamentOOP.Service;
using System;
using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit;


namespace StoreWithPagamentOOP;

public class Program
{
    static void Main()
    {
        var teste = "ola";
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse("kaikygabrielalves708@gmail.com"));
        email.To.Add(MailboxAddress.Parse("kaikygabrielalves707@gmail.com"));
        email.Subject = "Teste de envio com MailKit";

        email.Body = new TextPart("html")
        {
            Text =@"
                        <h1 style='color: darkblue;'>Olá, usuário!</h1>
        <p>Este é um <strong>e-mail em HTML</strong> enviado via <em>MailKit</em>.</p>
        <p>Clique aqui para visitar: <a href='https://example.com'>Nosso site</a></p>
        <hr />
        <p style='font-size: 12px; color: gray;'>Mensagem automática - não responda.</p>

                "
        };

        using var smtp = new SmtpClient();
        smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

        // Use sua senha de aplicativo, NÃO a senha normal!
        smtp.Authenticate("kaikygabrielalves708@gmail.com", "mtzb eqjg zjou ykzi");

        smtp.Send(email);
        smtp.Disconnect(true);

        Console.WriteLine("Email enviado com sucesso!");
    }
}