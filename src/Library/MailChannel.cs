using System;
using MailSenderApiUCU;

namespace Library {
    public class MailChannel : IMessageChannel {
        MailSender mailSender = new MailSender ("tomasorindelafuente11@gmail.com", "unacualquiera123!"); // Agregar correo y contraseña
        public void Send (Message message) 
        {
            mailSender.EnviarMail (message.From, "Mensaje de difusión", message.To, "Texto alternativo",  message.Text);
        }
        
    }
}