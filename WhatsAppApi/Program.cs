using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WhatsAppApiUCU {
    class Program {
        static void Main (string[] args) {
            string accountSid = "ACf9f49375b85485644966972156790a58";
            string authToken = "1c5c1c64cd098c7f658674785a7cf822";

            var whatsApp = new WhatsAppApi (accountSid, authToken);
            string sid = whatsApp.Send ("+14155238886", "Hey there! I'm using WhatsAppUCU");
            Console.WriteLine (sid);
        }
    }
}