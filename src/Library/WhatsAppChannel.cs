using System;
using WhatsAppApiUCU;

namespace Library {
    public class WhatsAppChannel : IMessageChannel {
        const string accountSid = "ACfbd57f50e199a28eac49de4cc4acfb8a";
        const string authToken = "81795970808380267013bf04070a5936";
        WhatsAppApi whatsApp = new WhatsAppApi (accountSid, authToken);
        public void Send (Message messageW)
        {
            whatsApp.Send (messageW.To, messageW.Text);
        }

        public Message createMessage(Contact fromW, Contact toW)
        {
            return new MessageWhatsApp(WhatsAppChannel.accountSid, toW.Phone, messageW.Text);
        }

    }

}