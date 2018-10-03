using System;
using MailSenderApiUCU;

namespace Library {
    public class Mail : IMessageChannel {
        MailSender mailSender = new MailSender ("@.", "");
        public void Send (Message message) 
        {
            mailSender.EnviarMail (message.From, "Mensaje de difusión", message.To, "Texto alternativo",  message.Text);
        }
        
    }
}