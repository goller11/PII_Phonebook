using System;

namespace MailSenderApiUCU {
    class Program {
        static void Main (string[] args) 
        {
            MailSender mailSender = new MailSender ("", "");
            bool sent = mailSender.EnviarMail ("Remitente", "<name>", "Destinatario", "<Subject>", "<Body>");
            Console.WriteLine (sent ? "Enviado." : "No enviado.");


        }
    }
}