using System;
using System.Collections.Generic;
using System.Text;

namespace ver4_biblTeo
{
    public class Book 
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
        public DateTime returnare { get; set; }
            //cred ca DateTime e variabila pt asta nuj 
            // -> daca EsteImprumutata e true atunci trebuie introdusa o data pt returnare
        public DateTime DataImprumutare { get; set; }   // pt a calcula intarzieri si plm

        public Book()
        {
            // nu scrie nimic aici, e folosit doar pt baza de date, 
            // e necesar sa existe
        }

        public Book(int ID, string titlu, string autor, string detalii, Client seAflaLa)
        {

            if (ID < 0) throw new ArgumentException("Trebuie sa introduceti un ID pozitiv");
            if (titlu == null || titlu == "") throw new ArgumentException("Trebuie sa introduceti titlul cartii");
            if (autor == null || autor == "") throw new ArgumentException("Trebuie sa introduceti numele autorului");

            this.ID = ID;
            this.Titlu = titlu;
            this.Autor = autor;
            this.Detalii = detalii;
            this.SeAflaLa = seAflaLa;

            if (this.SeAflaLa.Nume.ToLower() == "biblioteca")
                this.EsteImprumutata = false;
            else this.EsteImprumutata = true;  
        }

        public override string ToString()
        {
            return
                $"{this.ID}, {this.Titlu}, {this.Autor}, {this.Detalii}, {this.SeAflaLa}";
        }
    }
}
