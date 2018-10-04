using System;
using System.Collections.Generic;

namespace Library {
    public class MessageMail : Message {
        public MessageMail (string from, string to, string text) : base (from, to) {
            this.Text = text;
        }
    }
}