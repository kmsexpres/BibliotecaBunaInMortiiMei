using System;
using System.Data.Entity;

namespace ver4_biblTeo
{
    class Program
    {
        static void Main(string[] args)
        {
            // NU UITA SA STERGI ASTA
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookDb>());

            var user1 = new ApplicationInstance();
            try
            {
                Book b = new Book(1, "titlu", "autor", "detalii bla bla", "la mata");
                BookDb db = new BookDb();

                //db.Books.Add(b);
                //db.SaveChanges();
                Console.WriteLine(b);


                Client nou = new Client("theodor", "samson", "0752834925", "sucedava");
                //console.writeline(nou);
                nou.adaugaCarte(b);
                Console.WriteLine(nou);
                nou.afiseazaCartile();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }

            //int opt;

            //do
            //{
            //    Console.WriteLine("0. EXIT");
            //    Console.WriteLine("1. Adauga carte");
            //    Console.WriteLine("2. Afiseaza toate cartile");
            //    Console.WriteLine("3. Afiseaza cartile de la autorul X");
            //    Console.WriteLine("4. Afiseaza cartile imprumutate");

            //    Console.Write("Alegere: ");
            //    opt = int.Parse(Console.ReadLine());

            //    switch (opt)
            //    {
            //        case 1:
            //            var bk = user1.AdaugaCarte();
            //            bookDb.Books.Add(bk);
            //            break;
            //    }


            //}

        }
    }

    
}
