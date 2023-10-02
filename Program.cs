

using Advanced.FirstAssignment;

Boek boek1 = new Boek();
Boek boek2 = new Boek();
TijdSchrift tijdschrift1=new TijdSchrift();
TijdSchrift tijdschrift2 = new TijdSchrift();


boek1.Lees(boek1, "De Jacht", "TopBoeken", 45);
boek2.Lees(boek2, "Mijn leven", "Autobiographie", 18);
tijdschrift1.Lees(tijdschrift1, "Beste autos", "AutoKenner","Maandelijks", 5);
tijdschrift1.Lees(tijdschrift2, "Top eten", "DeChef", "Wekelijks", 7);

Console.WriteLine(boek1.ToString());
Console.WriteLine(boek2.ToString());
Console.WriteLine(boek1.Naam);

Console.WriteLine(tijdschrift1.ToString());
Console.WriteLine(tijdschrift2.ToString());
