using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.FirstAssignment
{
    internal class TijdSchrift:Boek
    {
        public Verschijningsperiode VerschijningsPeriode {  get; set; }
        public enum Verschijningsperiode
        {
            Dagelijks,
            Wekelijks,
            Maandelijks
        }
        public TijdSchrift() { }




        public void Lees(TijdSchrift tijdSchrift, string naam, string uitgever,string VerschijningsPerioded, double prijs)
        {
            tijdSchrift.Isbn = counter;
            tijdSchrift.Naam = naam;
            tijdSchrift.Uitgever = uitgever;
            tijdSchrift.Prijs = prijs;
            Verschijningsperiode dataVerschijning = (Verschijningsperiode)Enum.Parse(typeof(Verschijningsperiode), VerschijningsPerioded);
            tijdSchrift.VerschijningsPeriode = dataVerschijning;
            counter++;


            
        }
        public override string ToString()
        {
            return ("Isbn: "+Isbn + ", Naam: " + Naam + ", Uitgever: " + Uitgever + ", VerschijningsPeriode: " + VerschijningsPeriode + ", Prijs: " + Prijs);
        }

    }
}
