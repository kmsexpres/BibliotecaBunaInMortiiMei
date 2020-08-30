using System;
using System.Collections.Generic;
using System.Text;

namespace ver4_biblTeo
{
    class Book
    {
        public int ID { get; set; }    //nr inventariere gen
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Detalii { get; set; }
        public bool EsteImprumutata { get; set; }
        public Client SeAflaLa { get; set; }     //ori e in biblioteca, 
                                                 //ori e imprumutata la un om si contine datele acestuia
                                                 //biblioteca poate fi considerata ca un "client" special, 
                                                 //io zic ca merge

        public DateTime DataImprumutare
        {
            get => this.DataImprumutare;
            set
            { /* TODO PUNE CODU PENTRU VERIFICARE A DATELOR */ } 
        }   // pt a calcula intarzieri si plm

        public Book()
        {
            // nu scrie nimic aici, e folosit doar pt baza de date, 
            // e necesar sa existe
        }

        public Book(int ID, string titlu, string autor, string detalii, string seAflaLa)
        {
            this.ID = ID;
            this.Titlu = titlu;
            this.Autor = autor;
            this.Detalii = detalii;
            // this.SeAflaLa = asta este un nume de client, 
                // trebuie cautat in baza de date si returnat clientu respectiv

            /*if (this.SeAflaLa.Contains("bib"))
            {
                this.EsteImprumutata = false;
                this.SeAflaLa = "biblioteca";
            }
            else this.EsteImprumutata = true;*/
        }

        public override string ToString()
        {
            return
                $"{this.ID}, {this.Titlu}, {this.Autor}, {this.Detalii}, {this.SeAflaLa}";
        }
    }
}
