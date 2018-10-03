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

        public Contact AddContact (string contacto) 
        {
            Contact personC = new Contact(contacto);
            this.persons.Add(personC);
            return personC;
        }

        // Método para remover contactos

        public void RemoveContact (Contact contacto) {
            this.persons.Remove (contacto);
        }

        // Método para enviar mediante un canal, especificado por el usuario
        public void Send (String[] contactsList, IMessageChannel channelM, string textC) {
            
            Message messageC;
            List<Contact> contactsM = this.Search (contactsList);
            foreach (Contact contactM in contactsM) {
                messageC = channelM.createMessage(this.Owner, contactM);
                messageC.Text = textC;
                channelM.Send(messageC);
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