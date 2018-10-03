using System;
using MailSenderApiUCU;

namespace Library {
    public class MailChannel : IMessageChannel {
        MailSender mailSender = new MailSender ("@", ""); // Agregar correo y contraseña
        public void Send (Message message) 
        {
            mailSender.EnviarMail (message.From, "Mensaje de difusión", message.To, "Texto alternativo",  message.Text);
        }
        
    }
}