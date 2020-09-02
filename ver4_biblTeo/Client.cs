using System;
using System.Collections.Generic;
using System.Text;

namespace ver4_biblTeo
{
    class Client
    {
        // gen om care imprumuta
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
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

            this.Nume = nume;
            this.Prenume = prenume;
            this.Telefon = telefon;
            this.Adresa = adresa;
        }

        public void adaugaCarte(Book newBook)
        {
            cartiImprumutate.Add(newBook);
        }

        public void AfiseazaCartile()//toate cartile pe care le-a imprumutat clientul
        {
            foreach (Book carte in cartiImprumutate)
            {
                Console.WriteLine(carte);
            }
        }

        public override string ToString()
        {
            return
                $"{this.Nume}, {this.Prenume}, {this.Telefon}, {this.Adresa}, {this.cartiImprumutate}";
        }

        public string DateAdresa()
        {
            return
                $"{this.Nume}, {this.Prenume}, {this.Telefon}";
        }

    }
}
