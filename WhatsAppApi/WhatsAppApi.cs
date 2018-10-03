using System;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace WhatsAppApiUCU {
    public class WhatsAppApi {
        private string accountSid;
        private string authToken;

        public WhatsAppApi (string accountSid, string authToken) {
            this.accountSid = accountSid;
            this.authToken = authToken;
        }

        public string SendWhatsApp (string to, string text) {
            if (!to.StartsWith ("+598")) {
                return "El número al que mandás el mensaje debe comenzar con +598";
            }

            if (to.Length != 12) {
                return "Le faltan o sobran dígitos al número al que querés mandar el mensaje";
            }

            if (!Int64.TryParse (to, out _)) {
                return "El número al que mandás el mensaje tiene que tener sólo números";
            }

            TwilioClient.Init (this.accountSid, this.authToken);

            var message = MessageResource.Create (
                body: text,
                from: new Twilio.Types.PhoneNumber ("whatsapp:+14155238886"),
                to : new Twilio.Types.PhoneNumber ($"whatsapp:{to}")
            );

            return message.Sid;
        }
    }
}