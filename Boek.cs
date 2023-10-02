using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.FirstAssignment
{
    internal class Boek
    {

        public int Isbn { get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        public double Prijs { get; set; }


        public override string ToString()
        {
            return (Isbn + ", " + Naam + ", " + Uitgever + ", " + Prijs);
        }

        public void Lees(Boek boek,int isbn,string naam, string uitgever,double prijs)
        {
            boek.Isbn = isbn;
            boek.Naam = naam;
            boek.Uitgever = uitgever;
            boek.Prijs = prijs; 

        }
    }
}
