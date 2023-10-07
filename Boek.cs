using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.FirstAssignment
{
    
    internal class Boek
    {

        public static int counter = 1;

        public int Isbn { get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        public double Prijs { get; set; }

        public Boek() { }

        
        public override string ToString()
        {
            return ("Isbn: "+Isbn + ", Naam: " + Naam + ", Uitgever: " + Uitgever + ", Prijs: " + Prijs);
        }

        public void Lees(Boek boek,string naam, string uitgever,double prijs)
        {
            boek.Isbn = counter;
            boek.Naam = naam;
            boek.Uitgever = uitgever;
            boek.Prijs = prijs;
            counter++;
            

        }
        

    }
}
