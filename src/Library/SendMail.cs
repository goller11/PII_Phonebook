using System;
using MailSenderApiUCU;

namespace Library {
    public class Mail : IMessageChannel {
        MailSender mailSender = new MailSender ("basket.lagomar@gmail.com", "monodada14");
        public void Send (Message message) 
        {
            mailSender.EnviarMail (message.From, "Prueba", message.To, "Trial",  message.Text);
        }
        
    }
}