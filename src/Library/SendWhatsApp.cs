using System;
using MailSenderApiUCU;

namespace Library {
    public class WhatsApp : IMessageChannel {
        MailSender whatsAppSender = new MailSender ("basket.lagomar@gmail.com", "monodada14");
        public void Send (Message message) {
            whatsAppSender.EnviarMail (message.From, "Mensaje de difusión", message.To, "Texto alternativo", message.Text);
        }

    }
}