using System;
using System.Collections.Generic;
using WhatsAppApiUCU;

namespace Library {
    public class Phonebook {

        private List<Contact> persons;
        public Contact Owner { get; }

        public Phonebook (Contact owner) {
            this.Owner = owner;
            this.persons = new List<Contact> ();
        }

        // Método para agregar contactos

        public void AddContact (Contact contacto) {
            this.persons.Add (contacto);
        }

        // Método para remover contactos

        public void RemoveContact (Contact contacto) {
            this.persons.Remove (contacto);
        }

        // Método para enviar correo
        public void Send (String[] contactsList, MailChannel channelM, string message) {
            List<Contact> contactsM = this.Search (contactsList);
            foreach (Contact contactM in contactsM) {
                MessageMail messageM = new MessageMail (this.Owner.Email, contactM.Email, message);
                channelM.Send (messageM);
            }
        }

        // Método para enviar WhatsApp
        public void Send (String[] contactsList, WhatsAppChannel channelW, string messageW) {
            List<Contact> contactsW = this.Search (contactsList);
            foreach (Contact contactW in contactsW) {
                MessageWhatsApp messageWhatsApp = new MessageWhatsApp (Owner.Phone, contactW.Phone, messageW);
                channelW.Send (messageWhatsApp);
            }
        }

        public List<Contact> Search (string[] namesList) {
            List<Contact> result = new List<Contact> ();

            foreach (Contact person in this.persons) {
                foreach (string name in namesList) {
                    if (person.Name.Equals (name)) {
                        result.Add (person);
                    }
                }
            }
            return result;
        }
    }
}