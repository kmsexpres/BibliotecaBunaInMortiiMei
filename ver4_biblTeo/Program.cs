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
            var bookDb = new BookDb();

            int opt;

            do
            {
                Console.WriteLine("0. EXIT");
                Console.WriteLine("1. Adauga carte");
                Console.WriteLine("2. Afiseaza toate cartile");
                Console.WriteLine("3. Afiseaza cartile de la autorul X");
                Console.WriteLine("4. Afiseaza cartile imprumutate");

                Console.Write("Alegere: ");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        var bk = user1.AdaugaCarte();
                        bookDb.Books.Add(bk);
                        break;
                }


            }
            
        }
    }

    
}
