
using Advanced.FirstAssignment;
delegate void LogEventHandler(string bericht);


class Program
{

    static void Main(string[] args)
    {

        Boek boek1 = new Boek();
        Boek boek2 = new Boek();
        TijdSchrift tijdschrift1 = new TijdSchrift();
        TijdSchrift tijdschrift2 = new TijdSchrift();
        Bestelling<Boek> bestelling1 = new Bestelling<Boek>();
        Bestelling<Boek> bestelling2 = new Bestelling<Boek>();
        Bestelling<TijdSchrift> bestelling3 = new Bestelling<TijdSchrift>();
        Bestelling<TijdSchrift> bestelling4 = new Bestelling<TijdSchrift>();

        boek1.Lees(boek1, "De Jacht", "TopBoeken", 40);
        boek2.Lees(boek2, "Mijn leven", "Autobiographie", 18);
        tijdschrift1.Lees(tijdschrift1, "Beste autos", "AutoKenner", "Maandelijks", 5);
        tijdschrift1.Lees(tijdschrift2, "Top eten", "DeChef", "Wekelijks", 7);

        Console.WriteLine("Wilt u een boek(1) of een tijdschrift(2) abonnement kopen?");
         int keuze = Convert.ToInt32(Console.ReadLine());

        if (keuze ==1)
        {
            Console.WriteLine("De opties zijn:");
            Console.WriteLine("Optie 1: " + boek1.ToString());
            Console.WriteLine("Optie 2: " + boek2.ToString());
            Console.WriteLine("Welke wenst u te kopen?");
            int keuze2 = Convert.ToInt32(Console.ReadLine());
            if (keuze2 ==1)
            {
                Console.WriteLine("Hoeveel wilt u er bestellen?");
                int aantal = Convert.ToInt32(Console.ReadLine());
                bestelling1.log += new LogEventHandler(BestellingConfirmatie);
                Tuple<int, int, double> Besteld = bestelling1.Bestel(bestelling1,boek1, aantal);
            }
            else if (keuze2 ==2)
            {
                Console.WriteLine("Hoeveel wilt u er bestellen?");
                int aantal = Convert.ToInt32(Console.ReadLine());
                bestelling2.log += new LogEventHandler(BestellingConfirmatie);
                Tuple<int, int, double> Besteld = bestelling2.Bestel(bestelling2, boek2, aantal);
            }
        }
        else if (keuze == 2)
        {
            Console.WriteLine("De opties zijn:");
            Console.WriteLine("Optie 1: "+tijdschrift1.ToString());
            Console.WriteLine("Optie 2: "+tijdschrift2.ToString());
            Console.WriteLine("Welke wilt u zich voor abonneren?");
            int keuze2 = Convert.ToInt32(Console.ReadLine());
            if (keuze2 == 1)
            {
                Console.WriteLine("Hoeveel exemplaren wilt u per editie?");
                int aantal = Convert.ToInt32(Console.ReadLine());
                bestelling3.log += new LogEventHandler(BestellingConfirmatie);
                Tuple<int, int, double> Besteld = bestelling3.Bestel(bestelling3, tijdschrift1, aantal);
            }
            else if (keuze2 == 2)
            {
                Console.WriteLine("Hoeveel exemplaren wilt u per editie??");
                int aantal = Convert.ToInt32(Console.ReadLine());
                bestelling4.log += new LogEventHandler(BestellingConfirmatie);
                Tuple<int, int, double> Besteld = bestelling4.Bestel(bestelling4, tijdschrift2, aantal);
            }
        }


    }

    public static void BestellingConfirmatie(string bericht)
    {
        Console.WriteLine("Uw bestelling van " + bericht + " is gelukt!");
    }
}