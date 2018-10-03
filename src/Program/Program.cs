using System;
using System.Collections.Generic;
using Library;

namespace Program {
    class Program {
        static void Main (string[] args) {

            // Crear el contacto dueño

            Contact owner = new Contact ("Guillermo", "45677654", "basket.lagomar@gmail.com");
            Phonebook ownerPB = new Phonebook (owner);

            // Crear la lista de contactos

            Contact firstContact = new Contact ("Contact 1", "12344321", "guillevogel11@gmail.com");
            Contact secondContact = new Contact ("Contact 2", "56788765", "guillermo.vogel@correo.ucu.edu.uy");

            // Agregar contactos a la lista

            List<Contact> listContacts = new List<Contact> ();
            listContacts.Add (firstContact);
            listContacts.Add (secondContact);

            // Enviar un correo a algunos contactos

            ownerPB.SendMessage (new String[] { "firstContact" }, new Mail(), "Probando");

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos

            /* const string accountSid = "ACfbd57f50e199a28eac49de4cc4acfb8a";

            const string authToken = "81795970808380267013bf04070a5936"; */
        }
    }
}