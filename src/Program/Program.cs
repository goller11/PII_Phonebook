using System;
using System.Collections.Generic;
using Library;
using WhatsAppApiUCU;

namespace Program {
    class Program {
        static void Main (string[] args) {

            // Crear el contacto dueño

            Contact owner = new Contact ("Guillermo", "+14155238886", "basket.lagomar@gmail.com");
            Phonebook ownerPB = new Phonebook (owner);

            // Crear la lista de contactos

            Contact firstContact = new Contact ("Contact 1", "+59898242410", "guillevogel11@gmail.com");
            Contact secondContact = new Contact ("Contact 2", "56788765", "guillermo.vogel@correo.ucu.edu.uy");

            // Agregar contactos a la lista

            ownerPB.AddContact (firstContact);
            ownerPB.AddContact (secondContact);

            // Enviar un correo a algunos contactos

            ownerPB.SendMessage (new String[] { "Contact 1" }, new Mail (), "Probando el mail");

            // Enviar un WhatsApp a algunos contactos

            ownerPB.SendWhatsAPP (new String[] { "Contact 1" }, new WhatsApp (), "Probando el WhatsApp");

            // Enviar un SMS a algunos contactos
        }
    }
}