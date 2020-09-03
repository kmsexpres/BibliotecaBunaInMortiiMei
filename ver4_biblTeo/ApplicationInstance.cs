using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ver4_biblTeo
{
    class ApplicationInstance
    {
        // nu e neaparat necesara clasa asta da gen
        // mie imi place sa ma gandesc la o aplicatie ca o instanta
        // si gen pot fi definite mai multe instante, 
        // pt mai multe pc-uri de ex

        // ce e scris aici ar fi scris in main direct

        public Book AdaugaCarte()
        {
            // citesc datele de la tastatura
            // generez obiectu nou si il returnez

            Console.Write("ID: ");
            var ID = int.Parse(Console.ReadLine());

            Console.Write("Titlu: ");
            var titlu = Console.ReadLine();

            Console.Write("Autor: ");
            var autor = Console.ReadLine();

            Console.Write("Detalii (enter pt final): ");
            var detalii = Console.ReadLine();

            Console.WriteLine("Locatie (biblioteca sau Nume_Prenume client): ");
            var locatie = Console.ReadLine();

            // cand este inregistraza cartea pt prima data, daca este in bilbioteca ii pun data inregistrarii
            var dataImprumut = DateTime.Now;
            if(!locatie.Contains("bib"))
            {
                // altfel citesc data imprumutului
                Console.WriteLine("Data imprumutului (zz/ll/aaaa): ");
                dataImprumut = DateTime.Parse(Console.ReadLine(), new CultureInfo("ro-RO"));
            }

            Book newBook = null;
            try
            {
                // aici primesc exceptie in caz ca au fost introduse date proaste
                newBook = new Book(ID, titlu, autor, detalii, Client.GetFakeBiblioteca());
                //newBook.DataImprumutare = dataImprumut;
            }
            catch(InvalidDataException e)
            {
                Console.WriteLine($"Au fost introduse date gresite: {e.Message}");
            }
            finally
            {
                if(newBook is null)
                {
                    throw new InvalidDataException("Eroare la inregistrarea cartii, reincercati.");
                }
            }
            return newBook; // doamne ajuta poate e construita cum trebuie
        }

    }
}
