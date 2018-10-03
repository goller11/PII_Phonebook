using System;
using System.Collections.Generic;

namespace Library {
    public class Phonebook {

        private List<Contact> persons;
        public Contact Owner { get; }

        public Phonebook (Contact owner) 
        {
            this.Owner = owner;
            this.persons = new List<Contact> ();
        }

        // Método para agregar contactos

        public void AddContact (Contact contacto) 
        {
            this.persons.Add (contacto);
        }

        // Método para remover contactos

        public void RemoveContact (Contact contacto) 
        {
            this.persons.Remove (contacto);
        }

        public void SendMessage (String[] contactsList, Mail channel, string message) 
        {
            List<Contact> contacts = this.Search (contactsList);
            foreach (Contact contact in contacts) 
            {
                MessageMail messageM = new MessageMail (this.Owner.Email, contact.Email, message);
                channel.Send (messageM);
            }
        }

        public List<Contact> Search (string[] namesList) 
        {
            List<Contact> result = new List<Contact> ();

            foreach (Contact person in this.persons) 
            {
                foreach (string name in namesList) 
                {
                    if (person.Name.Equals (name)) 
                    {
                        result.Add (person);
                    }
                }
            }
            return result;
        }
    }
}