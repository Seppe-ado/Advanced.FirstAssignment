using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.FirstAssignment
{
    internal class Bestelling<T>: Baseline
    {
        
        

        public event LogEventHandler log;
        protected void WanneerBesteld(string bericht)
        {
            if (log != null)
            {
                log(bericht);
            }
        }


        public int Id { get; }
        public T Item { get; set; }
        public DateTime Datum { get; set; }
        public int Aantal { get; set; }

        public Bestelling()
        {
            Id = ++idBestelling;

        }

        internal Tuple<int, int, double> Bestel( Bestelling<T> bestelling,T item, int aantal)
        {
            bestelling.Item = item;
            bestelling.Datum = DateTime.Now;
            bestelling.Aantal = aantal;
                 if (item is TijdSchrift tijdSchrift)
                {
                    if (tijdSchrift.Prijs > 50)
                    {
                    tijdSchrift.Prijs = 50;
                    }
                    else if (tijdSchrift.Prijs < 5)
                    {
                    tijdSchrift.Prijs = 5;
                    }
                    double prijs = tijdSchrift.Prijs * aantal;

                    
                    WanneerBesteld(bestelling.Aantal +" tijdschrift(en) met naam: " +tijdSchrift.Naam+", op datum: "+bestelling.Datum + " ,voor de prijs van: " + prijs);
                    return Tuple.Create(tijdSchrift.Isbn, aantal, prijs);
                } else if (item is Boek boek)
                {

                    if (boek.Prijs > 50)
                    {
                    boek.Prijs = 50;
                    }
                    else if (boek.Prijs < 5)
                    {
                    boek.Prijs = 5;
                    }

                    double prijs = boek.Prijs * aantal;
                    WanneerBesteld(bestelling.Aantal + " boek(en) met naam: " + boek.Naam + ", op datum: " + bestelling.Datum+" ,voor de prijs van: "+prijs);
                    return Tuple.Create(boek.Isbn, aantal, prijs);

                }

            return null;
        }
    }
}

