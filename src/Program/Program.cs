using System;
using System.Collections.Generic;
using Library;

namespace Program {
    class Program {
        static void Main (string[] args) {

            // Crear el contacto dueño

            Contact ownerContact = new Contact ("Guillermo"); //, "+14155238886", "tomasorindelafuente11@gmail.com");
            Phonebook ownerBook = new Phonebook (ownerContact);
            // Crear la lista de contactos

            Contact firstContact = ownerBook.AddContact ("Contact 1"); //, "+59898242410", "guillevogel11@gmail.com");
            Contact secondContact = ownerBook.AddContact ("Contact 2"); //, "+59894585797", "guillermo.vogel@correo.ucu.edu.uy");
            
            firstContact.Email = "guillevogel11@gmail.com";
            secondContact.Email = "guillermo.vogel@correo.ucu.edu.uy";
            
            firstContact.Phone = "+59898242410";

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            ownerBook.Send (new String[] { "Contact 1" }, new MailChannel (), "Probando el mail");
            // Hay que agregar correo y contraseña en SendMail.cs para que funcione correctamente.

            // Enviar un WhatsApp a algunos contactos

            //ownerBook.Send (new String[] { "Contact 1" }, new WhatsAppChannel (), "Probando el WhatsApp");

            // Enviar un SMS a algunos contactos --> No hay API
        }
    }
}