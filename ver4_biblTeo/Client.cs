using System;
using System.Collections.Generic;
using System.Text;

namespace ver4_biblTeo
{
    class Client
    {
        // gen om care imprumuta
        public string nume { get; set; }
        public string prenume { get; set; }
        public string telefon { get; set; }
        public string adresa { get; set; }
        public List<Book> cartiImprumutate = new List<Book>();

        public Client()
        {
            //las gol ca am presupus ca si aici trebuie un constructor basic
        }

        public Client(string nume, string prenume, string telefon, string adresa)
        {
            if (nume == null || nume == "") throw new ArgumentException("Completati numele");

            if (prenume == null || prenume == "") throw new ArgumentException("Completati prenumele");

            if (telefon == null || telefon == "") throw new ArgumentException("Completati numarul de telefon");

            if (adresa == null || adresa == "") throw new ArgumentException("Completati adresa");

            this.nume = nume;
            this.prenume = prenume;
            this.telefon = telefon;
            this.adresa = adresa;
        }

        public void adaugaCarte(Book newBook)
        {
            cartiImprumutate.Add(newBook);
        }

        public void afiseazaCartile()//toate cartile pe care le-a imprumutat clientul
        {
            foreach (Book carte in cartiImprumutate)
            {
                Console.WriteLine(carte);
            }
        }

        public override string ToString()
        {
            return
                $"{this.nume}, {this.prenume}, {this.telefon}, {this.adresa}, {this.cartiImprumutate}";
        }

    }
}
