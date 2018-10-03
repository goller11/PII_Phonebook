using System;
using System.Collections.Generic;
using Library;

namespace Program {
    class Program {
        static void Main (string[] args) {

            // Crear el contacto dueño

            Contact ownerContact = new Contact ("Guillermo", "+14155238886", "tomasorindelafuente11@gmail.com");
            Phonebook ownerBook = new Phonebook (ownerContact);

            // Crear la lista de contactos

            Contact firstContact = new Contact ("Contact 1", "+59898242410", "guillevogel11@gmail.com");
            Contact secondContact = new Contact ("Contact 2", "+59894585797", "guillermo.vogel@correo.ucu.edu.uy");
            Contact thirdContact = new Contact ("Contact 3", "+59899999999", "tomasorindelafuente11@gmail.com");
            // Agregar contactos a la lista

            ownerBook.AddContact (firstContact);
            ownerBook.AddContact (secondContact);

            // Enviar un correo a algunos contactos

            ownerBook.Send (new String[] { "Contact 1" }, new MailChannel (), "Probando el mail");
            // Hay que agregar correo y contraseña en SendMail.cs para que funcione correctamente.

            // Enviar un WhatsApp a algunos contactos

            ownerBook.Send (new String[] { "Contact 1" }, new WhatsAppChannel (), "Probando el WhatsApp");

            // Enviar un SMS a algunos contactos --> No hay API
        }
    }
}