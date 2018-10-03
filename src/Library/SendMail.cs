using System;
using MailSenderApiUCU;

namespace Library {
    public class Mail : IMessageChannel {
        MailSender mailSender = new MailSender ("", "");
        public void Send (Message message) 
        {
            mailSender.EnviarMail (message.From, "Prueba", message.To, "Trial",  message.Text);
        }
        
    }
}
