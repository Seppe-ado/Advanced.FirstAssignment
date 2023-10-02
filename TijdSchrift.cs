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
        public string VerschijningsPeriode {  get; set; }

        public void Lees(TijdSchrift tijdSchrift, string naam, string uitgever,string VerschijningsPeriode, double prijs)
        {
            tijdSchrift.Isbn = counter;
            tijdSchrift.Naam = naam;
            tijdSchrift.Uitgever = uitgever;
            tijdSchrift.Prijs = prijs;
            tijdSchrift.VerschijningsPeriode = VerschijningsPeriode;
            counter++;
        }
        public override string ToString()
        {
            return (Isbn + ", " + Naam + ", " + Uitgever + ", " + VerschijningsPeriode + ", " + Prijs);
        }

    }
}
